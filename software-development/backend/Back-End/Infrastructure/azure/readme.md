Azure Resource Deployment

This repository contains an Azure Resource Manager (ARM) template (azuredeploy.json) for deploying a C# ASP.NET 7 project, with Docker support, to Azure.

The resources that will be created are:
Azure Container Registry (ACR)
App Service Plan
App Service

The Docker image of the application will be stored in the ACR and the App Service will run the application from this image.

Pre-requisites
An Azure account with an active subscription.
Azure CLI installed on your machine.

How to Deploy
1. Log in to Azure account using: `az login`
2. Create a resource group `az deployment group create --name backend-resources --resource-group backend-resources --template-file ./azuredeploy.json --parameters @parameters.json`
3. Modifiy the `parameters.json` file and replace the values of the parameters for your needs.