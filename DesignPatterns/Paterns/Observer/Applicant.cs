namespace DesignPatterns.Paterns.Observer
{
    public class Applicant
    {
        string fname;
        string lname;
        string emailID;
        string phoneNo;
        public Applicant()
        {
            
        }
        public void Update(Job appliedJob)
        {
            switch (appliedJob.status)
            {
                case JobStatus.FILLED:
                    //Do something like sending email, //updating database, etc
                    break;
                case JobStatus.REMOVED:
                    //Do something like sending email, //updating database, etc
                    break;
                case JobStatus.SUSPENDED:
                    //Do something like sending email, //updating database, etc
                    break;
            }
            //Your own functionality
            //End Of Functionality
        }
    }
}
}