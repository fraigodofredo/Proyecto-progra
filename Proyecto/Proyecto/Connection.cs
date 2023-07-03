/*
 * Created by SharpDevelop.
 * User: Vaio
 * Date: 02/07/2023
 * Time: 04:06 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Proyecto
{
	/// <summary>
	/// Description of Connection.
	/// </summary>
	public partial class Connection : Form
	{
		
		MySqlConnection conexion;
		
		

		public Connection()
		{
			
					   /** Instancia a clase conexion de MySQL */
		    this.conexion = new MySqlConnection();
		   try
		     {
		        //Se forma la cadena de conexion con los datos de nuestro servidor
		        //Server: 120.0.0.1 o localhost
		        //Database: Nombre de la base de datos
		        //user id: usario
		        //Pwd: Contraseña del servidor
		        this.conexion.ConnectionString = "Server=127.0.0.1; Database=proyecto programacion; User id=root;";
		        this.conexion.Open();//Se abre una conexion a la base de datos
		        Console.WriteLine("Conexión realizada con exito: Estado " + conexion.State);
		        this.conexion.Close();//Se cierra conexion
		      }
		      catch (MySqlException ex)
		      {   //Si ocurio un error -> Muestra el tipo de error
		          Console.WriteLine("Error:" + ex.Message);
		      }
		      //paramos la consola hasta que se presione una tecla
		}
		

		public int Insert(MainForm.Datos datos)
{
			int id = -1;
    string query = "INSERT into cliente (Nombre_Cliente, Telefono_Cliente, Direccion_Cliente, Email_Cliente) VALUES ('%Nombre_Cliente%', %Telefono_Cliente%, '%Direccion_Cliente%', '%Email_Cliente%')";
    query = query.Replace("%Nombre_Cliente%",datos.Nom).Replace("%Telefono_Cliente%",datos.Tel).Replace("%Direccion_Cliente%",datos.Dir).Replace("%Email_Cliente%",datos.Email);
    //open conexion
    if (this.OpenConnection() == true)
    {
        //create command and assign the query and conexion from the constructor
        MySqlCommand cmd = new MySqlCommand(query, this.conexion);
        
        //Execute command
        cmd.ExecuteNonQuery();
        String query_nuevo = "SELECT max(Num_Cliente) id FROM cliente";
        MySqlCommand cmd_2 = new MySqlCommand(query_nuevo,this.conexion);
        MySqlDataReader dataReader = cmd_2.ExecuteReader();
        while (dataReader.Read())
        {
        	id= int.Parse(dataReader["id"].ToString());

        }
        //close Data Reader
        dataReader.Close();
        //close conexion
        this.CloseConnection();
        
    }
    return id;
}

//Update statement
public void Update(MainForm.Datos datos)
{
    string query = "UPDATE tableinfo SET name='Joe', age='22' WHERE name='John Smith'";

    //Open conexion
    if (this.OpenConnection() == true)
    {
        //create mysql command
        MySqlCommand cmd = new MySqlCommand();
        //Assign the query using CommandText
        cmd.CommandText = query;
        //Assign the conexion using Connection
        cmd.Connection = conexion;

        //Execute query
        cmd.ExecuteNonQuery();

        //close conexion
        this.CloseConnection();
    }
}

//Delete statement
public void Delete(MainForm.Datos datos)
{
    string query = "DELETE FROM tableinfo WHERE name='John Smith'";

    if (this.OpenConnection() == true)
    {
        MySqlCommand cmd = new MySqlCommand(query, conexion);
        cmd.ExecuteNonQuery();
        this.CloseConnection();
    }
}

private bool OpenConnection()
{
    try
    {
        conexion.Open();
        return true;
    }
    catch (MySqlException ex)
    {
        //When handling errors, you can your application's response based 
        //on the error number.
        //The two most common error numbers when connecting are as follows:
        //0: Cannot connect to server.
        //1045: Invalid user name and/or password.
        switch (ex.Number)
        {
            case 0:
                MessageBox.Show("Cannot connect to server.  Contact administrator");
                break;

            case 1045:
                MessageBox.Show("Invalid username/password, please try again");
                break;
        }
        return false;
    }
}

//Close conexion
private bool CloseConnection()
{
    try
    {
        conexion.Close();
        return true;
    }
    catch (MySqlException ex)
    {
        MessageBox.Show(ex.Message);
        return false;
    }
}
	}
}
