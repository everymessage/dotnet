using System;
using System.Collections.Generic;

using everymessage.Workflow.V1;
using everymessage.WebAPI.Auth;

namespace everymessage.Workflow.V1.Examples
{
    public class SubmitQueryDeleteExamples
    {
        public static void Example1()
        {

            everymessageCredential credential = everymessageCredential.Create("demo", "2sd3ODILm5wXzcWPPKe4CwPK9gDEPk@JsAL7q9!pKANCJWtwN0!skDRta67z@NvY");
            WorkflowClient client = WorkflowClient.Create("https://api.everymessage.com/workflow/", credential);
            
            // SUBMIT example

            SubmitRecordsRequest submitRequest = new SubmitRecordsRequest()
            {
                InstanceName = "demo_simple_sms",
                Records = new List<WorkflowRecord>()
                {
                    new WorkflowRecord()
                    {
                        PrimaryReference = "DEMO001",
                        FirstName = "Mark",
                        PhoneNumber = "07777777777",
                        Variables = new List<WorkflowVariable>()
                        {
                            WorkflowVariable.Create("amount", 311.24M),
                            WorkflowVariable.Create("due", DateTime.Now.ToString("dd MMM yyyy"))
                        }
                    },
                    new WorkflowRecord()
                    {
                        PrimaryReference = "DEMO002",
                        FirstName = "Hannah",
                        PhoneNumber = "07777777778",
                        Variables = new List<WorkflowVariable>()
                        {
                            WorkflowVariable.Create("amount", 16.07M),
                            WorkflowVariable.Create("due", DateTime.Now.ToString("dd MMM yyyy"))
                        }
                    }
                }
            };
            
            var submitResponse = client.SubmitRecords(submitRequest);

            // QUERY example

            QueryRecordsRequest queryRequest = new QueryRecordsRequest()
            {
                Records = new List<long>() { submitResponse.Body.Records[0].WorkflowRecordId, submitResponse.Body.Records[1].WorkflowRecordId },
                IncludeActivities = true,
                IncludeSmsInformation = true,
                IncludeEmailInformation = true,
                IncludeRepositoryData = true
            };

            var queryResponse = client.QueryRecords(queryRequest);

            // DELETE example

            DeleteRecordsRequest deleteRequest = new DeleteRecordsRequest()
            {
                Records = new List<long>() { submitResponse.Body.Records[0].WorkflowRecordId, submitResponse.Body.Records[1].WorkflowRecordId }
            };

            var deleteResponse = client.DeleteRecords(deleteRequest);

            Console.Read();
        }


    }
}
