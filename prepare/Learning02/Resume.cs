public class resume {
    public string _name = "";
    public List<job> _jobs = new List<job>();

    public void displayResume(){
        Console.WriteLine($"Name: {_name}\nJobs:");
        foreach (job j in _jobs){
            j.DisplayInfo();
        }
    }
}