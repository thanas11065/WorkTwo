class Program {
    static void Main(string[] args){
        // Info myInfo = CreateInfo(name,score,id,score,g);
        myInfo2 = CreateInfo(string name,string surname,long id,int score);

        PrintInfo(string name,string surname,long id,int score);
        PrintInfo(myInfo2);
        /*
        PrintInfo(myInfo3);
        PrintInfo(myInfo4);
        PrintInfo(myInfo5);
        PrintInfo(myInfo6);
        PrintInfo(myInfo7);
        PrintInfo(myInfo8);
        */
        long id1 = Info.ConvertStringToLongID(id);
    }
    static Info CreateInfo(string name ,string surname ,string id ,string score /*,string grade*/){ //Constructor-โครงสร้าง
        return new Info(name,surname,id,score/*,grade*/);
    }
    static void PrintInfo(string name,string surname,long id,int score/*,string grade*/) {
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
        Console.WriteLine("Name : {0} {1}",name,surname);
        Console.WriteLine("ID : {0}",id);
        Console.WriteLine("Score : {0}",score);
        Console.WriteLine("Grade : {0}" /*,data.grade*/);
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
    }
}
public class Info {
    public string name = "Name : ";
    public string surname = "Surname : ";
    public string id = "ID : ";
    public string score = "Score : ";
    /* public string grade; */
    public Info(string name,string surname,string id,string score/*,string grade*/) {
        this.name = name;
        this.surname = surname;
        this.id = id;
        this.score = score;
        /*this.grade = grade;*/
    }
    public string PrintGrade(){
        return this.gradeInformation.ShowGrade();
    }
    public string PrintScore(){
        return this.gradeInformation.ShowScore();
    }

}