using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationFramework.ProjectLib
{
    public class RunData : IRunData
    {
        private static IConfigurationRoot _configuration;

        public RunData()
        {
            _configuration = SelectConfig.get().getConfiguration();
        }

        public string TestAccountPassword => GetValue("AccountPassword");
        public string NewAccountInCaseflow => GetValue("newaccount");
        public string DigitalXAuthTicket => GetValue("DigitalXAuthTicket");
        public string DigitalRegisterAccount => GetValue("DigitalRegisterAccount");
        public string DeleteAccountInCaseflow => GetValue("delete_account");
        public string AssignRepcodeInCaseflow => GetValue("repcode");
        public string DigitalDeregisterAccount => GetValue("De_registerURL");
        public string DigitalDeregClientId => GetValue("DeReg_ClientId");
        public string DigitalSecretKey => GetValue("DeReg_ClientSecret");
        public string CreateDDPlanInCaseflow => GetValue("DDPlan_URL");
        public string NewPaymentPlanInCaseflow => GetValue("SetupPaymentPlan");
        public string RetContactDetailsCaseflow => GetValue("RetContactDetails_URL");
        public string DigitalAuthToken => GetValue("TokenURL");
        public string CreateBudgetCalEntryCaseflow => GetValue("PostBudgetCal_URL"); 
        public string RetBudgetCalEntryCaseflow => GetValue("RetBudgetCal_URL");
        public string ClientIdCaseflow => GetValue("client_id");
        public string ClientSecretCaseflow => GetValue("client_secret");
        public string GrantType => GetValue("grant_type");
        public string TokenContentType => GetValue("Token_Content_Type");
        public string TokenRequestType => GetValue("Token_Request_Type");
        public string ContentType => GetValue("Content-Type");
        public string RequestType => GetValue("Request_Type");
        public string EnterBankDetailsInCaseflow => GetValue("SetupBankDetails");
        public string DBServerName => GetValue("DB-Server");
        public string DatabaseName => GetValue("DB-DatabaseName");
        public string DatabaseUsername => GetValue("DB-User");
        public string DatabasePassword => GetValue("DB-Password");
        public string UsersTablename => GetValue("EmailConfirmation_TableName");
        public string UserTokensTablename => GetValue("Tokens_TableName");
        public string UserPropertiesTablename => GetValue("UserId_TableName");
        public string UserRolesTablename => GetValue("UserRoles_TableName");
        public string UserLegacyPassTablename => GetValue("UserLegPass_TableName");
        public string Registration_API => GetValue("Registration_URL");        

        private static string GetValue(string key)
        {
            return _configuration[key];
        }
    }

    public interface IRunData
    {
        string TestAccountPassword { get; }
        string NewAccountInCaseflow { get; }
        string DigitalXAuthTicket { get; }
        string DigitalRegisterAccount { get; }
        string DeleteAccountInCaseflow { get; }
        string AssignRepcodeInCaseflow { get; }
        string DigitalDeregisterAccount { get; }
        string DigitalDeregClientId { get; }
        string DigitalSecretKey { get; }
        string CreateDDPlanInCaseflow { get; }
        string NewPaymentPlanInCaseflow { get; }
        string RetContactDetailsCaseflow { get; }
        string DigitalAuthToken { get; }
        string CreateBudgetCalEntryCaseflow { get; }
        string RetBudgetCalEntryCaseflow { get; }
        string ClientIdCaseflow { get; }
        string ClientSecretCaseflow { get; }
        string GrantType { get; }
        string TokenContentType { get; }
        string TokenRequestType { get; }
        string ContentType { get; }
        string RequestType { get; }
        string DBServerName { get; }
        string DatabaseName { get; }
        string DatabaseUsername { get; }
        string DatabasePassword { get; }
        string UsersTablename { get; }
        string UserTokensTablename { get; }
        string UserPropertiesTablename { get; }
        string UserRolesTablename { get; }
        string UserLegacyPassTablename { get; }
        string Registration_API { get; }
        string EnterBankDetailsInCaseflow { get; }

    }
}
