namespace DataSource;

public interface DataSource
{
    public void writeData(string data) { }
    public void readData() { }

}

public class FileDataSource : DataSource
{
    private string? filename;


    public void writeData(string data) { }  
    public void readData() { }

    public  FileDataSource(string filename)
    {
       this.filename = filename;
    }

}

public class DataSourceDecorator : DataSource
{
    private DataSource? wrappee;

    public void writeData(string data)
    {
        // Your implementation here
    }

    public void readData()
    {
        
    }

    // Corrected constructor with the same name as the class
    public  DataSourceDecorator(DataSource wrappee)
    {
        this.wrappee = wrappee;
    }
}


public class EncryotionDecorator
{ 


    public void writeData(string data)
    {

    }

    public void readData() { }


  

}

public class CompressionDecorator
{


    public void writeData(string data)
    {

    }

    public void readData() { }




}


