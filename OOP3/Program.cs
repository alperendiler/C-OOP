




using OOP3;

ICreditManager mortgageCreditManager = new MortgageCreditManager();

ICreditManager vehicleCreditManager = new VehicleCreditManager();

ICreditManager personalFinanceCreditManager = new PersonalFinanceCreditManager();


List<ILoggerService> loggers = new List<ILoggerService> {new DatabaseLoggerService(),new FileLoggerService(),new SmsLoggerService() };


ApplicationManager applicationManager = new ApplicationManager();
applicationManager.MakeAApplication(mortgageCreditManager, loggers);


List<ICreditManager> credits = new List<ICreditManager>() { mortgageCreditManager,vehicleCreditManager,personalFinanceCreditManager };

//applicationManager.GivePreliminaryCreditInformation(credits);








