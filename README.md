# Building Modular Components with Orchard Core Framework

## Modular Orchard Core Web Applications

# [YouTube Video](https://youtu.be/ao7tR4kj2aw)

[![OrchardSkillsYouTubeThumbNailModular](https://user-images.githubusercontent.com/54124010/90764624-cde46500-e2a5-11ea-82c4-6b4408f55fbc.png)](https://youtu.be/ao7tR4kj2aw)

# Introduction

The Orchard Core framework was designed with modularity in mind :  A modular design can be characterized by functional partitioning into discrete scalable and reusable components.



![Orchard-Core-Modular-001](https://user-images.githubusercontent.com/54124010/90764388-7f36cb00-e2a5-11ea-9913-52004234b36d.png)

Launch Visual Studio and select "Create a new project".



![Orchard-Core-Modular-002](https://user-images.githubusercontent.com/54124010/90764394-81992500-e2a5-11ea-801d-98394788b6f7.png)

Select "ASP.NET Core Web Application" and click the "Next" button.



![Orchard-Core-Modular-003](https://user-images.githubusercontent.com/54124010/90764397-82ca5200-e2a5-11ea-9690-b2fff2e06a91.png)

Enter the project name "OrchardCoreModularMVCWebApplication" and select the "Create" button.



![Orchard-Core-Modular-004](https://user-images.githubusercontent.com/54124010/90764401-8362e880-e2a5-11ea-9ba7-9b5275aa3e78.png)

Select "Web Application" and press the "Create" button.



![Orchard-Core-Modular-005](https://user-images.githubusercontent.com/54124010/90764405-84941580-e2a5-11ea-8080-f9da76304c52.png)

As you can see, the "OrchardCoreModularMVCWebApplication" project was created.



![Orchard-Core-Modular-006](https://user-images.githubusercontent.com/54124010/90764406-852cac00-e2a5-11ea-859d-8e04bee6a0c8.png)

Lets add another project. Right click on the solution, select "Add" then "New Project...".



![Orchard-Core-Modular-007](https://user-images.githubusercontent.com/54124010/90764409-85c54280-e2a5-11ea-91ea-aa7ee0503606.png)

Select "ASP.NET Core Web Application" and click the "Next" button.



![Orchard-Core-Modular-008](https://user-images.githubusercontent.com/54124010/90764411-865dd900-e2a5-11ea-80fc-b6cda873ee5d.png)

Enter the project name "OrchardCoreModularEmptyWebApplication" and press the "Create" button.



![Orchard-Core-Modular-009](https://user-images.githubusercontent.com/54124010/90764413-86f66f80-e2a5-11ea-8f1a-3602bb9a6718.png)

Select "Empty" and the press the "Create" button.



![Orchard-Core-Modular-010](https://user-images.githubusercontent.com/54124010/90764416-86f66f80-e2a5-11ea-9029-f679d1daad69.png)

As you can see, the "OrchardCoreModularEmptyWebApplication" was created.



![Orchard-Core-Modular-011](https://user-images.githubusercontent.com/54124010/90764421-878f0600-e2a5-11ea-87de-433c70923321.png)

Lets add another project. Right click on the solution, select "Add" then "New Project...".



![Orchard-Core-Modular-012](https://user-images.githubusercontent.com/54124010/90764429-88c03300-e2a5-11ea-967e-30aafb77f141.png)

Select "Class Library (.NET Core)" and click the "Next" button.



![Orchard-Core-Modular-013](https://user-images.githubusercontent.com/54124010/90764431-8958c980-e2a5-11ea-97c7-31405203d9a5.png)

Enter "OrchardCoreModualLibrary" for the project name and click the "Create" button.



![Orchard-Core-Modular-014](https://user-images.githubusercontent.com/54124010/90764433-8958c980-e2a5-11ea-8a1c-4436553fa45c.png)

Lets add another project. Right click on the solution, select "Add" then "New Project...".



![Orchard-Core-Modular-015](https://user-images.githubusercontent.com/54124010/90764434-89f16000-e2a5-11ea-9b3a-41d1823533ec.png)

Select "ASP.NET Core Web Application" and click the "Next" button.



![Orchard-Core-Modular-016](https://user-images.githubusercontent.com/54124010/90764435-8b228d00-e2a5-11ea-9031-dc15286b0358.png)

Enter "OrchardCoreModualWebAPI" for the project name and click the "Create" button.



![Orchard-Core-Modular-017](https://user-images.githubusercontent.com/54124010/90764436-8b228d00-e2a5-11ea-9476-b7ee3b3c3aa3.png)

Select "API" and press the "Create" button.

![Orchard-Core-Modular-018](https://user-images.githubusercontent.com/54124010/90764437-8bbb2380-e2a5-11ea-8088-97e1c03842a3.png)

As you can see the projects were created.



![Orchard-Core-Modular-019](https://user-images.githubusercontent.com/54124010/90764439-8c53ba00-e2a5-11ea-9bc4-5cb147407782.png)

Lets add a new item to the solution. Right click on the solution, select "Add" and then "New Item...".



![Orchard-Core-Modular-020](https://user-images.githubusercontent.com/54124010/90764441-8cec5080-e2a5-11ea-8701-4cee549fe6e5.png)

Lets add a "Text File" and select the "Add" button.



![Orchard-Core-Modular-021](https://user-images.githubusercontent.com/54124010/90764442-8d84e700-e2a5-11ea-8873-5bb0c864f78d.png)

Right click on the "TextFile.txt" and select "Rename". 



![Orchard-Core-Modular-022](https://user-images.githubusercontent.com/54124010/90764447-8e1d7d80-e2a5-11ea-81eb-8c08de58a16d.png)

**Note**: Orchard Core changed the Orchard Preview Feed.

Rename it to "NuGet.config". Add the following text:

```
<?xml version="1.0" encoding="utf-8"?>
<configuration>
  <packageSources>
    <clear />
    <add key="nuget.org" value="https://www.nuget.org/api/v2/" />
  </packageSources>
  <activePackageSource>
    <add key="All" value="(Aggregate source)" />
  </activePackageSource>
</configuration>
```



![Orchard-Core-Modular-023](https://user-images.githubusercontent.com/54124010/90764450-8eb61400-e2a5-11ea-9b4e-ea243affa4bb.png)

Exit Visual Studio. You can press the "X" (Close) in the upper right corner.



![Orchard-Core-Modular-024](https://user-images.githubusercontent.com/54124010/90764452-8f4eaa80-e2a5-11ea-8075-d2ed2f9a4bf3.png)

Restart Visual Studio and Select the OrchardCoreModualMFCWebApplication" solution.



![Orchard-Core-Modular-025](https://user-images.githubusercontent.com/54124010/90764454-907fd780-e2a5-11ea-96fb-50752e70c587.png)

Visual Studio reloaded the solution.

![Orchard-Core-Modular-026](https://user-images.githubusercontent.com/54124010/90764456-91186e00-e2a5-11ea-9d76-6db22a060d9f.png)

Click on the "OrchardCoreModularLibrary"  modify the project to the following:

```
<Project Sdk="Microsoft.NET.Sdk.Web">

  <PropertyGroup>
    <TargetFramework>netcoreapp3.1</TargetFramework>
    <OutputType>Library</OutputType>
  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include="OrchardCore.Module.Targets" Version="1.0.0-rc2-13450" />
  </ItemGroup>

</Project>
```



![Orchard-Core-Modular-027](https://user-images.githubusercontent.com/54124010/90764458-91b10480-e2a5-11ea-8327-3954f52a762d.png)

Modify the "Startup.cs" file to:

```
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace OrchardCoreModularLibrary
{
    public class Startup
    {
        public void Configure(IEndpointRouteBuilder endpoint)
        {
            endpoint.MapGet("/ecommerce", async context =>
            {
                await context.Response.WriteAsync("ModularLibrary!");
            });
        }
    }
}
```



![Orchard-Core-Modular-028](https://user-images.githubusercontent.com/54124010/90764461-92e23180-e2a5-11ea-9fe5-f647eccbabaa.png)

Select "Build" then "Build OrchardCoreModularLibrary".



![Orchard-Core-Modular-029](https://user-images.githubusercontent.com/54124010/90764463-937ac800-e2a5-11ea-9103-960bd44cae3a.png)

Project built successfully.

![Orchard-Core-Modular-030](https://user-images.githubusercontent.com/54124010/90764465-94135e80-e2a5-11ea-8589-bdd179bf8985.png)

Select the "OrchardCoreModularEmptyWebApplication" project. Modify it to the following:

```
<Project Sdk="Microsoft.NET.Sdk.Web">

  <PropertyGroup>
    <TargetFramework>netcoreapp3.1</TargetFramework>
  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include="OrchardCore.Application.Targets" Version="1.0.0-rc2-13450" />
  </ItemGroup>

  <ItemGroup>
    <ProjectReference Include="..\OrchardCoreModularLibrary\OrchardCoreModularLibrary.csproj" />
  </ItemGroup>

</Project>

```



![Orchard-Core-Modular-031](https://user-images.githubusercontent.com/54124010/90764469-94abf500-e2a5-11ea-9e59-c3ca68709020.png)

Click on the "Startup.cs" file. Modify it to the following:

```
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace OrchardCoreModularEmptyWebApplication
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddOrchardCore();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
            });

            app.UseOrchardCore();
        }
    }
}
```



![Orchard-Core-Modular-032](https://user-images.githubusercontent.com/54124010/90764472-95dd2200-e2a5-11ea-9976-4bbf30265609.png)

Select "Build" then "Build OrchardCoreModularEmptyWebApplication".

![Orchard-Core-Modular-033](https://user-images.githubusercontent.com/54124010/90764474-9675b880-e2a5-11ea-9596-0c7ae9532630.png)

Build was successful.

![Orchard-Core-Modular-034](https://user-images.githubusercontent.com/54124010/90764475-970e4f00-e2a5-11ea-9e21-dcb8f93c98f7.png)

Run the application by clicking on the green play button.



![Orchard-Core-Modular-035](https://user-images.githubusercontent.com/54124010/90764477-983f7c00-e2a5-11ea-9f4c-78d30042fcc9.png)

Congratulations your app is running.

![Orchard-Core-Modular-036](https://user-images.githubusercontent.com/54124010/90764478-983f7c00-e2a5-11ea-9ae7-bbbc6bfa369f.png)

Right click on "Dependencies" and then "Add Reference...".



![Orchard-Core-Modular-037](https://user-images.githubusercontent.com/54124010/90764480-9970a900-e2a5-11ea-8a07-4ae1207988c0.png)

Click on "OrchardCoreModularLibrary" to enable it and then press the "OK" button.



![Orchard-Core-Modular-038](https://user-images.githubusercontent.com/54124010/90764484-9a093f80-e2a5-11ea-937e-e6fa53c8d40c.png)

Run the application and go to the URL "/ModularLibrary". Congraulations, the ModularLibrary is now integrated.



![Orchard-Core-Modular-039](https://user-images.githubusercontent.com/54124010/90764485-9aa1d600-e2a5-11ea-80cd-03054b592329.png)

Click on the "OrchardCoreModularWebAPI" project and modify it to the following:

```
<Project Sdk="Microsoft.NET.Sdk.Web">

  <PropertyGroup>
    <TargetFramework>netcoreapp3.1</TargetFramework>
    <OutputType>Library</OutputType>
    <IsPackable>true</IsPackable>
    <PackageVersion>1.0.0-rc1-10004</PackageVersion>
  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include="OrchardCore.Module.Targets" Version="1.0.0-rc2-13450" />
  </ItemGroup>

  <ItemGroup>
    <Folder Include="wwwroot\" />
  </ItemGroup>

</Project>
```



![Orchard-Core-Modular-040](https://user-images.githubusercontent.com/54124010/90764486-9b3a6c80-e2a5-11ea-909a-bbd97815a9fa.png)

Click on "Build" then "Build OrchardCoreModularWebAPI". 



![Orchard-Core-Modular-041](https://user-images.githubusercontent.com/54124010/90764487-9bd30300-e2a5-11ea-9512-ef56fca75893.png)

Build was successful.



![Orchard-Core-Modular-042](https://user-images.githubusercontent.com/54124010/90764490-9c6b9980-e2a5-11ea-8184-3d2d81d730b6.png)

Select "Build" then "Build OrchardCOreModularMCVWebApplication".



![Orchard-Core-Modular-043](https://user-images.githubusercontent.com/54124010/90764491-9d043000-e2a5-11ea-8d5d-c3502d7d5102.png)

Build was successful.



![Orchard-Core-Modular-044](https://user-images.githubusercontent.com/54124010/90764495-9d9cc680-e2a5-11ea-9104-972288af40c9.png)

Run the application by clicking on the green play button.



![Orchard-Core-Modular-045](https://user-images.githubusercontent.com/54124010/90764498-9ecdf380-e2a5-11ea-90b2-271fef6a8501.png)

Congratulations, your Application is running.



![Orchard-Core-Modular-046](https://user-images.githubusercontent.com/54124010/90764501-9ecdf380-e2a5-11ea-8d04-cde6ad35cf9c.png)

Select the "OrchardCoreModularMVCWebApplication" project, right click on "dependencies" and "Add Reference...".



![Orchard-Core-Modular-047](https://user-images.githubusercontent.com/54124010/90764505-9fff2080-e2a5-11ea-93ed-80f8a19c8b4e.png)

Clink on both "OrchardCOreModularLibrary" and "OrchardCoreModularWebAPI".



![Orchard-Core-Modular-048](https://user-images.githubusercontent.com/54124010/90764511-a097b700-e2a5-11ea-8f82-a876a6bf64ec.png)

Run the application by clicking the green play button.



![Orchard-Core-Modular-049](https://user-images.githubusercontent.com/54124010/90764515-a1304d80-e2a5-11ea-9b29-5c3f1fb1cc12.png)

Congradulations, your Application is running.

![Orchard-Core-Modular-050](https://user-images.githubusercontent.com/54124010/90764518-a1c8e400-e2a5-11ea-9e79-8678e2c28a30.png)

Now browse to "/ModularLibrary". You can see the modular library integrated.

![Orchard-Core-Modular-051](https://user-images.githubusercontent.com/54124010/90764520-a2617a80-e2a5-11ea-87cc-766172f44a03.png)

Now browse to "/WeatherForcast". You can now see the weather data from the API.

# Conclusion

With the Orchard Core modular framework, multiple teams can work on separate modules. The functional of an application can be added to a module.  These modules can be toolkits and reused in other applications. A module can contain static assets, scripts, images, middleware, authentication, or user interface such as a dashboard.

# GitHub

The complete source code is located [here](https://github.com/OrchardSkills/OrchardSkills.OrchardCore.Modular).


