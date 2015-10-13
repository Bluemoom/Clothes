using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for NguoiDung
/// </summary>
public class NguoiDung
{
	public NguoiDung(int id, int Role)
	{
        this.id = id;
        this.Role = Role;
	}

    public int id { get; set; }
    public int Role { get; set; }
}