const ENV = {
  dev: {
    apiUrl: 'http://localhost:44304',
    oAuthConfig: {
      issuer: 'http://localhost:44304',
      clientId: 'Solution_App',
      clientSecret: '1q2w3e*',
      scope: 'Solution',
    },
    localization: {
      defaultResourceName: 'Solution',
    },
  },
  prod: {
    apiUrl: 'http://localhost:44304',
    oAuthConfig: {
      issuer: 'http://localhost:44304',
      clientId: 'Solution_App',
      clientSecret: '1q2w3e*',
      scope: 'Solution',
    },
    localization: {
      defaultResourceName: 'Solution',
    },
  },
};

export const getEnvVars = () => {
  // eslint-disable-next-line no-undef
  return __DEV__ ? ENV.dev : ENV.prod;
};
