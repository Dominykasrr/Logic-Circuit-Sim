using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

public class CircuitForm
{
	public Circuit CurCircuit { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    public CircuitForm()
    {
        this.CurCircuit = new Circuit();
    }

	public void Save(String path) 
    {
        FileStream fs = null;
        BinaryFormatter bf = null;

        try
        {
            fs = new FileStream(path, FileMode.Create, FileAccess.Write);
            bf = new BinaryFormatter();
            bf.Serialize(fs, CurCircuit);
        }
        catch (SerializationException) { }
        catch (IOException) { }
        finally
        {
            if (fs != null) fs.Close();
        }
	}

	public void Load(String path)
	{
        FileStream fs = null;
        BinaryFormatter bf = null;

        try
        {
            fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            bf = new BinaryFormatter();
            CurCircuit = (Circuit)(bf.Deserialize(fs));
        }
        catch (SerializationException) { }
        catch (IOException) { }
        finally
        {
            if (fs != null) fs.Close();
        }
	}

	public void New()
	{
        this.CurCircuit = new Circuit();
	}

}

