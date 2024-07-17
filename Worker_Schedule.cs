class Worker_Schedule : Scheduleing
{
    public void ViewListOfAvailabilitiesWorkers()
    {
        List<Worker> listOfWorkers = worker.CreateInstanceofWorker();
        List<string> listOfWorkerAvailabilities = new();
        int countOfNumberOfWokersInList = listOfWorkers.Count();
        
            
        foreach (Worker Employee in listOfWorkers)
        {
            System.Console.WriteLine($"Employee Name: {Employee.f_name} {Employee.l_name} \nAvailabilities:");
                foreach (string availability in Employee.availability)
                    {
                        System.Console.WriteLine(availability);
                    }
                
            // foreach (Worker workerInfo in listOfWorkers)
            // {
            //     string workerInfoString = workerInfo.ToString();
            //     string [] workerInfoStirngSplit = workerInfoString.Split(' ');


            // }


        }
    }

}