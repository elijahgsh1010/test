const ENV = {
  dev: {
        apiUrl: 'http://localhost:44321',
    oAuthConfig: {
        issuer: 'http://localhost:44318',
        clientId: 'Test_App',
      clientSecret: '1q2w3e*',
        scope: 'offline_access Test',
    },
    localization: {
        defaultResourceName: 'Test',
    },
  },
  prod: {
      apiUrl: 'http://localhost:44321',
    oAuthConfig: {
        issuer: 'http://localhost:44318',
        clientId: 'Test_App',
      clientSecret: '1q2w3e*',
        scope: 'offline_access Test',
    },
    localization: {
        defaultResourceName: 'Test',
    },
  },
};

export const getEnvVars = () => {
  // eslint-disable-next-line no-undef
  return __DEV__ ? ENV.dev : ENV.prod;
};
