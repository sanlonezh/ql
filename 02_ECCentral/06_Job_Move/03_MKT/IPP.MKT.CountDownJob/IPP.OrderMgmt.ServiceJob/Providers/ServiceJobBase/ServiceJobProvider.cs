using System;
using System.Configuration.Provider;
using System.Text;
using System.Threading;
using IPP.OrderMgmt.ServiceJob.Properties;


namespace IPP.OrderMgmt.ServiceJob.Providers
{
    public abstract class ServiceJobProvider : ProviderBase
    {
        private Thread m_JobThread;
        public Thread JobThread
        {
            get { return m_JobThread; }
            set { m_JobThread = value; }
        }

        private ServiceJobInfo m_JobInfo;
        public ServiceJobInfo JobInfo
        {
            get { return m_JobInfo; }
            set { m_JobInfo = value; }
        }

        public abstract void PostData();

        public void StartJob()
        {
            m_JobThread = new Thread(new ThreadStart(this.JobStarting));
            m_JobThread.Start();
        }

        //public void StopJob()
        //{
        //    m_JobThread.Abort();
        //}

        public bool CheckRunTime()
        {
            // 可以使用提供者模式
            switch (m_JobInfo.JobType)
            {
                case ServiceJobType.Daily:
                    goto default;
                case ServiceJobType.Weekly:
                    return false;
                case ServiceJobType.Monthly:
                    return false;
                case ServiceJobType.OneTimeOnly:
                    return false;
                case ServiceJobType.Repeter:
                    return CheckRepeterJobRunTime();
                default:
                    return CheckDailyJobRunTime();
            }
        }

        private bool CheckDailyJobRunTime()
        {
            bool canrun = false;

            string[] rumtime = JobInfo.RunTime.Split(';');
            for (int i = 0; i < rumtime.Length; i++)
            {
                if (DateTime.Now.ToString("HH:mm") == rumtime[i].Trim())
                {
                    canrun = true;
                    break;
                }
            }

            return canrun;
        }

        private bool CheckRepeterJobRunTime()
        {
            bool canrun = false;

            string[] rumtime = JobInfo.RunTime.Split(';');

            // 开始的时间
            string startTime = rumtime[0];

            // 间隔的分钟数
            int spanMinute = Int32.Parse(rumtime[1]);

            // 今天的分钟数
            int minute = DateTime.Now.Hour * 60 + DateTime.Now.Minute;

            if (minute % spanMinute == 0)
            {
                canrun = true;
            }

            return canrun;
        }

        private void JobStarting()
        {
            Log.WriteLog(String.Format(Resources.ScheduleJobStarted, JobInfo.JobName), m_JobInfo.InfoLog, true);
            if (JobInfo.SetRunning())
            {
                try
                {
                    PostData();
                }
                catch (Exception ex)
                {
                    Log.WriteLog(ex.Message, m_JobInfo.InfoLog, true);
                    Log.WriteLog(ex.ToString(), m_JobInfo.ErrorLog, true);
                }
                finally 
                { 
                    JobInfo.ReleaseRunning();
                    Log.WriteLog(String.Format(Resources.ScheduleJobEnded, JobInfo.JobName), m_JobInfo.InfoLog, true);
                }
            }
            else
            { 
                Log.WriteLog(String.Format(Resources.JobRunning, JobInfo.JobName), m_JobInfo.InfoLog, true);
            }
        }

        protected void SendMail()//SalesOrder order)
        {
            //try
            //{
            //    ReportMail reportMail = JobConfiguration.GetReportMail("Prx_ReportMailJob_Error");
            //    EmailV10 email = new EmailV10();

            //    email.Body.From = reportMail.MailFrom;
            //    email.Body.ReplyTo = reportMail.MailTo;
            //    email.Body.ReceiverMail = reportMail.MailTo;
            //    email.Body.CcList = reportMail.MailCC;
            //    email.Body.MailSubject = reportMail.MailSubject.Replace("{Date}",
            //        DateTime.Now.ToShortDateString());
            //    email.Body.BccList = "";
            //    email.Body.MailBody = BuildMailBody(order, reportMail.Template);

            //    email.Body.MailFormat = EmailV10.MailFormat.Text;

            //    Newegg.Oversea.Global.CommonManagement.ServiceContracts.Utilities.ISendMailV10 proxy =
            //        ServiceBroker.FindService<Newegg.Oversea.Global.CommonManagement.ServiceContracts.Utilities.ISendMailV10>();
            //    proxy.SendMail(email);
            //}
            //catch (Exception ex)
            //{
            //    Log.WriteLog(String.Format(Resources.JobError, JobInfo.JobName, ex.ToString()), JobInfo.ErrorLog, false);
            //}
        }

        //private string BuildMailBody(SalesOrder order, string rowTemplate)
        //{
        //    StringBuilder s = new StringBuilder();
        //    s.Append(rowTemplate);
        //    s.Replace("[SONumber]", order.Body.SalesOrder.SONumber.ToString());
        //    s.Replace("[JobName]", GetType().ToString());
        //    s.Replace("[Error_Code]", order.Fault.ErrorCode);
        //    s.Replace("[Error_Description]", order.Fault.ErrorDescription);
        //    s.Replace("[Error_Detail]", order.Fault.ErrorDetail);
        //    return s.ToString();
        //}
    }
}
