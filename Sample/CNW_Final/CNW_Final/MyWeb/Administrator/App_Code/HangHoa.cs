using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for HangHoa
/// </summary>
public class HangHoa
{
	public HangHoa(int id,int sl )
	{
        this.id = id;
        this.sl = sl;
	}
    public int sl { get; set; }
    public int id { get; set; }
    public string name { get; set; }
        
}