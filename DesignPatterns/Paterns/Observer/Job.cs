using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Paterns.Observer
{
    public enum JobStatus { FILLED, SUSPENDED, REMOVED };
   
    public class Job
    {
        private ArrayList applicants;
        private JobStatus statusOfJob;

        public Job()
        {
            applicants = new ArrayList();
        }

        public JobStatus status
        {
            get { return statusOfJob; }

            set { 
                statusOfJob = value;
                Notify();
            }
        }
        public void Add(Applicant candidate)
        {
            applicants.Add(candidate);
        }
        public void Remove(Applicant candidate)
        {
            applicants.Remove(candidate);
        }

        public void Notify()
        {
            foreach(Applicant applicant in applicants)
            {
                applicant.Update(this);
            }
        }
    }
}
