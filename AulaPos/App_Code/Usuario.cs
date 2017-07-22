using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Usuario
/// </summary>
public class Usuario
{
    #region
    public int usu_id { get; set; }
    public string usu_nome { get; set; }
    public string usu_login { get; set; }
    public string usu_senha{ get; set; }
    public bool usu_ativo { get; set; }
   
   
    #endregion


    public Usuario()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public Usuario(int pUsuId) 
    {
        DataSet.TbUsuarioDataTable tbUsuario = new DataSet.TbUsuarioDataTable();
        DataSetTableAdapters.TbUsuarioTableAdapter dsUsuario = new DataSetTableAdapters.TbUsuarioTableAdapter();
        dsUsuario.FillByUsuId(tbUsuario, pUsuId);

        if (tbUsuario.Rows.Count > 0)
        {
            DataSet.TbUsuarioRow regUsuario = (DataSet.TbUsuarioRow)tbUsuario.Rows[0];

            this.usu_id = regUsuario.usu_id;
            this.usu_nome = regUsuario.usu_nome;
            this.usu_login = regUsuario.usu_login;
            this.usu_senha = regUsuario.usu_senha;
            this.usu_ativo = regUsuario.usu_ativo;
        }
    }
}