# HelloWorld Azure AI Experimentation Program

This is a simple C# console application that demonstrates how to connect to Azure AI services for experimentation purposes.

## Features

- Connects to Azure AI Project resources using the Azure SDK.
- Demonstrates authentication with Azure using `DefaultAzureCredential`.
- Lists connections from an Azure AI Project resource.

## Prerequisites

- Visual Studio 2022
- .NET Framework 4.7.2
- An active Azure subscription
- An Azure AI Project resource endpoint
- [Azure CLI](https://docs.microsoft.com/en-us/cli/azure/install-azure-cli) (for local authentication)

## Setup

1. **Clone the repository:**

2. **Open the solution in Visual Studio 2022.**

3. **Install required NuGet packages:**
   - `Azure.Identity`
   - `Azure.AI.Projects`

   You can install them using the Package Manager Console:

4. **Configure authentication:**
   - Sign in to Azure in Visual Studio, or
   - Install Azure CLI and run `az login` in your terminal.

5. **Set your Azure AI Project endpoint:**
   - Update the `projectEndpoint` variable in `Program.cs` with your Azure AI Project resource endpoint.

## Usage

1. Build and run the application.
2. The program will attempt to connect to your Azure AI Project and list available connections.

## Example
