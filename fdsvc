[1mdiff --git a/src/StoreSpa.Web.Api/StoreSpa.Web.Api.csproj b/src/StoreSpa.Web.Api/StoreSpa.Web.Api.csproj[m
[1mindex c8ec593..7df5086 100644[m
[1m--- a/src/StoreSpa.Web.Api/StoreSpa.Web.Api.csproj[m
[1m+++ b/src/StoreSpa.Web.Api/StoreSpa.Web.Api.csproj[m
[36m@@ -1,4 +1,5 @@[m
[31m-﻿<Project ToolsVersion="12.0" DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">[m
[32m+[m[32m﻿<?xml version="1.0" encoding="utf-8"?>[m
[32m+[m[32m<Project ToolsVersion="12.0" DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">[m
   <Import Project="..\packages\Microsoft.CodeDom.Providers.DotNetCompilerPlatform.1.0.3\build\Microsoft.CodeDom.Providers.DotNetCompilerPlatform.props" Condition="Exists('..\packages\Microsoft.CodeDom.Providers.DotNetCompilerPlatform.1.0.3\build\Microsoft.CodeDom.Providers.DotNetCompilerPlatform.props')" />[m
   <Import Project="..\packages\Microsoft.Net.Compilers.1.3.2\build\Microsoft.Net.Compilers.props" Condition="Exists('..\packages\Microsoft.Net.Compilers.1.3.2\build\Microsoft.Net.Compilers.props')" />[m
   <Import Project="$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props" Condition="Exists('$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props')" />[m
[36m@@ -14,7 +15,7 @@[m
     <AppDesignerFolder>Properties</AppDesignerFolder>[m
     <RootNamespace>StoreSpa.Web.Api</RootNamespace>[m
     <AssemblyName>StoreSpa.Web.Api</AssemblyName>[m
[31m-    <TargetFrameworkVersion>v4.6.1</TargetFrameworkVersion>[m
[32m+[m[32m    <TargetFrameworkVersion>v4.5</TargetFrameworkVersion>[m
     <UseIISExpress>true</UseIISExpress>[m
     <IISExpressSSLPort />[m
     <IISExpressAnonymousAuthentication />[m
[36m@@ -23,6 +24,7 @@[m
     <UseGlobalApplicationHostFile />[m
     <NuGetPackageImportStamp>[m
     </NuGetPackageImportStamp>[m
[32m+[m[32m    <TargetFrameworkProfile />[m
   </PropertyGroup>[m
   <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">[m
     <DebugSymbols>true</DebugSymbols>[m
[36m@@ -54,10 +56,6 @@[m
     <Reference Include="System.ComponentModel.DataAnnotations" />[m
     <Reference Include="System" />[m
     <Reference Include="System.Data" />[m
[31m-    <Reference Include="System.Core" />[m
[31m-    <Reference Include="System.Data.DataSetExtensions" />[m
[31m-    <Reference Include="System.Web.Extensions" />[m
[31m-    <Reference Include="System.Xml.Linq" />[m
     <Reference Include="System.Drawing" />[m
     <Reference Include="System.Web" />[m
     <Reference Include="System.Xml" />[m
[1mdiff --git a/src/StoreSpa.Web.Api/Web.config b/src/StoreSpa.Web.Api/Web.config[m
[1mindex b6c4c73..641a943 100644[m
[1m--- a/src/StoreSpa.Web.Api/Web.config[m
[1m+++ b/src/StoreSpa.Web.Api/Web.config[m
[36m@@ -1,21 +1,28 @@[m
[31m-﻿<?xml version="1.0" encoding="utf-8"?>[m
[32m+[m[32m﻿<?xml version="1.0"?>[m
 <!--[m
   For more information on how to configure your ASP.NET application, please visit[m
   https://go.microsoft.com/fwlink/?LinkId=301879[m
   -->[m
 <configuration>[m
[31m-  <appSettings></appSettings>[m
[32m+[m[32m  <appSettings/>[m
[32m+[m[32m  <!--[m
[32m+[m[32m    For a description of web.config changes see http://go.microsoft.com/fwlink/?LinkId=235367.[m
[32m+[m
[32m+[m[32m    The following attributes can be set on the <httpRuntime> tag.[m
[32m+[m[32m      <system.Web>[m
[32m+[m[32m        <httpRuntime targetFramework="4.5" />[m
[32m+[m[32m      </system.Web>[m
[32m+[m[32m  -->[m
   <system.web>[m
[31m-    <compilation debug="true" targetFramework="4.6.1"/>[m
[31m-    <httpRuntime targetFramework="4.6.1"/>[m
[32m+[m[32m    <compilation debug="true" targetFramework="4.5"/>[m
[32m+[m[32m    <httpRuntime targetFramework="4.5"/>[m
   </system.web>[m
   <system.webServer>[m
     <handlers>[m
       <remove name="ExtensionlessUrlHandler-Integrated-4.0"/>[m
       <remove name="OPTIONSVerbHandler"/>[m
       <remove name="TRACEVerbHandler"/>[m
[31m-      <add name="ExtensionlessUrlHandler-Integrated-4.0" path="*." verb="*" type="System.Web.Handlers.TransferRequestHandler"[m
[31m-        preCondition="integratedMode,runtimeVersionv4.0"/>[m
[32m+[m[32m      <add name="ExtensionlessUrlHandler-Integrated-4.0" path="*." verb="*" type="System.Web.Handlers.TransferRequestHandler" preCondition="integratedMode,runtimeVersionv4.0"/>[m
     </handlers>[m
   </system.webServer>[m
   <runtime>[m
[36m@@ -36,12 +43,10 @@[m
   </runtime>[m
   <system.codedom>[m
     <compilers>[m
[31m-      <compiler language="c#;cs;csharp" extension=".cs"[m
[31m-        type="Microsoft.CodeDom.Providers.DotNetCompilerPlatform.CSharpCodeProvider, Microsoft.CodeDom.Providers.DotNetCompilerPlatform, Version=1.0.3.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"[m
[31m-        warningLevel="4" compilerOptions="/langversion:6 /nowarn:1659;1699;1701"/>[m
[31m-      <compiler language="vb;vbs;visualbasic;vbscript" extension=".vb"[m
[31m-        type="Microsoft.CodeDom.Providers.DotNetCompilerPlatform.VBCodeProvider, Microsoft.CodeDom.Providers.DotNetCompilerPlatform, Version=1.0.3.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"[m
[31m-        warningLevel="4" compilerOptions="/langversion:14 /nowarn:41008 /define:_MYTYPE=\&quot;Web\&quot; /optionInfer+"/>[m
[32m+[m[32m      <compiler language="c#;cs;csharp" extension=".cs" type="Microsoft.CSharp.CSharpCodeProvider, System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" warningLevel="4" compilerOptions="/langversion:6 /nowarn:1659;1699;1701">[m
[32m+[m[32m          <providerOption name="CompilerVersion" value="v4.0"/>[m
[32m+[m[32m      </compiler>[m
[32m+[m[32m      <compiler language="vb;vbs;visualbasic;vbscript" extension=".vb" type="Microsoft.CodeDom.Providers.DotNetCompilerPlatform.VBCodeProvider, Microsoft.CodeDom.Providers.DotNetCompilerPlatform, Version=1.0.3.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" warningLevel="4" compilerOptions="/langversion:14 /nowarn:41008 /define:_MYTYPE=\&quot;Web\&quot; /optionInfer+"/>[m
     </compilers>[m
   </system.codedom>[m
[31m-</configuration>[m
[32m+[m[32m</configuration>[m
\ No newline at end of file[m
