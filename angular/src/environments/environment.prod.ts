import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'Test',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44318',
    redirectUri: baseUrl,
    clientId: 'Test_App',
    responseType: 'code',
    scope: 'offline_access Test',
  },
  apis: {
    default: {
      url: 'https://localhost:44321',
      rootNamespace: 'Test',
    },
  },
} as Environment;
