public class AppSettings
{
    private static AppSettings instance;
    public string name;

    private AppSettings(){

    }

    public static AppSettings getInstance(){
        if(instance == null){
            instance = new AppSettings();
        }
        return instance;
    }
}