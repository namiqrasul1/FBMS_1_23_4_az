using TemplateDesignPattern;

SqlEngine sqlEngine = new MsSqlEngine();

sqlEngine.TemplateMethod("select top(100) * from users");
