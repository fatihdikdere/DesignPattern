using ChainOfResponsibility;

var technicalSupport = new TechnicalSupport();
var managerSupport = new ManagerSupport();

technicalSupport.SetNextSupportHandler(managerSupport);

technicalSupport.HandleRequest();

Console.WriteLine(Environment.NewLine);

managerSupport.HandleRequest();

Console.ReadKey();