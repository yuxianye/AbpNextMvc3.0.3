using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Volo.Abp;
using Volo.Abp.Domain.Entities;

namespace Solution.Orders
{
    public class Order : AggregateRoot<Guid>
    {
        public virtual string ReferenceNo { get; protected set; }

        public virtual int TotalItemCount { get; protected set; }

        public virtual DateTime CreationTime { get; protected set; }

        public virtual List<OrderLine> OrderLines { get; protected set; }

        protected Order()
        {

        }

        public Order(Guid id, string referenceNo)
        {
            Check.NotNull(referenceNo, nameof(referenceNo));

            Id = id;
            ReferenceNo = referenceNo;

            OrderLines = new List<OrderLine>();
        }

        public void AddProduct(Guid productId, int count)
        {
            if (count <= 0)
            {
                throw new ArgumentException(
                    "You can not add zero or negative count of products!",
                    nameof(count)
                );
            }

            var existingLine = OrderLines.FirstOrDefault(ol => ol.ProductId == productId);

            if (existingLine == null)
            {
                OrderLines.Add(new OrderLine(this.Id, productId, count));
            }
            else
            {
                existingLine.ChangeCount(existingLine.Count + count);
            }

            TotalItemCount += count;
        }
    }

    public class OrderLine : Entity
    {
        public virtual Guid OrderId { get; protected set; }

        public virtual Guid ProductId { get; protected set; }

        public virtual int Count { get; protected set; }

        protected OrderLine()
        {

        }

        internal OrderLine(Guid orderId, Guid productId, int count)
        {
            OrderId = orderId;
            ProductId = productId;
            Count = count;
        }

        internal void ChangeCount(int newCount)
        {
            Count = newCount;
        }

        public override object[] GetKeys()
        {
            return new Object[] { OrderId, ProductId };
        }
    }
}
