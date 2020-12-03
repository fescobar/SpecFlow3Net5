# SpecFlow3Net5 with Allure
Project for reproducing error

```sh

The type initializer for 'Allure.SpecFlowPlugin.AllureBindingInvoker' threw an exception. -> Couldn't find Allure configuration file. Please either specify full path to allureConfig.json in the ALLURE_CONFIG environment variable or place allureConfig.json to the 'C:\Users\fescobar\.nuget\packages\allure.commons\3.5.0.4\lib\netstandard2.0' folderSystem.TypeInitializationException: The type initializer for 'Allure.SpecFlowPlugin.AllureBindingInvoker' threw an exception.
 ---> System.IO.FileNotFoundException: Couldn't find Allure configuration file. Please either specify full path to allureConfig.json in the ALLURE_CONFIG environment variable or place allureConfig.json to the 'C:\Users\fescobar\.nuget\packages\allure.commons\3.5.0.4\lib\netstandard2.0' folder
   at Allure.Commons.AllureLifecycle.GetDefaultJsonConfiguration()
```

