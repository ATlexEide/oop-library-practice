public class Option{
    String Id;
    public Option(String _id,Action method){
Id = _id;
method.Invoke();
    }
}