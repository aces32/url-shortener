# url-shortener
Lets build it: Url Shortener

## Infrastructure as Code

### Log in into Azure
```bash
az login
```

### Create Resource Group

```bash
az group create --name urlshortener-dev --location westeurope
```

### Deploy Bicep

### What If

```bash
az deployment group  what-if --resource-group urlshortener-dev --template-file infrastructure/main.bicep
```

### Deploy

```bash
az deployment group  create --resource-group urlshortener-dev --template-file infrastructure/main.bicep
```

### Create User For GH Actions
```bash
az ad sp create-for-rbac `
    --name "GitHub-Actions-SP" `
    --role contributor `
    --scopes /subscriptions/b9ef21a8-8452-4224-a2cc-f167a0512642 `
    --sdk-auth
```

#### Configure a federated identity credential on an app
https://learn.microsoft.com/en-gb/entra/workload-id/workload-identity-federation-create-trust?pivots=identity-wif-apps-methods-azp#configure-a-federated-identity-credential-on-an-app

### Get Azure Publish Profile
```bash
az webapp deployment list-publishing-profiles --name api-r6hdzf62s5jdi --resource-group urlshortener-dev --xml
```