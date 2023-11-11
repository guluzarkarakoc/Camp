

using OOP3;
using static OOP3.DataBaseLoggerService;

ICreditManager personalFinanceCredit = new PersonalFinanceCredit();
//personalFinanceCredit.Compute();

ICreditManager transportCredit = new TransportCredit();
//transportCredit.Compute();

ICreditManager homeLoansManager = new HomeLoansManager();
//homeLoansManager.Compute();


ILoggerService databaseloggerService = new DataBaseLoggerService();
ILoggerService fileLoggerService = new FileLoggerService();


RecourseManager recourseManager = new RecourseManager();
recourseManager.ToRecourse(personalFinanceCredit, new DataBaseLoggerService());


List <ICreditManager> credits = new List<ICreditManager>() {personalFinanceCredit };
recourseManager.PreInformation(credits);

    
