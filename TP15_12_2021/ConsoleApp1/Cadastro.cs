using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Cadastro
    {
        private List<Usuario> usuarios;
        private List<Ambiente> ambientes;

        internal List<Usuario> Usuarios { get => usuarios; set => usuarios = value; }
        internal List<Ambiente> Ambientes { get => ambientes; set => ambientes = value; }

        public Cadastro()
        {
            this.Usuarios = new List<Usuario>();
            this.Ambientes = new List<Ambiente>();
        }

        public void adicionarUsuario(Usuario usuario)
        {
            Usuarios.Add(usuario);
        }
        public bool removerUsuario(Usuario usuario)
        {
            foreach(Usuario usu in usuarios)
            {
                if (usu.Id == usuario.Id)
                {
                    if (usu.Ambientes.Count == 0)
                    {
                        usuarios.Remove(usu);
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Revoge permissoes para conseguir remover o usuario.");
                        return false;
                    }
                }
            }
            return false;
        }

        public Usuario pesquisarUsuario(Usuario usuario)
        {
            foreach (Usuario usu in Usuarios)
            {
                if (usu.Id == usuario.Id)
                {
                    return usu;
                }
            }
            return usuario;
        }
        public void adicionaAmbiente(Ambiente ambiente)
        {
            Ambientes.Add(ambiente);
        }
        public bool removerAmbiente(Ambiente ambiente)
        {
            foreach (Ambiente amb in Ambientes)
            {
                if (amb.Id == ambiente.Id)
                {
                    Ambientes.Remove(amb);
                    return true;
                }
            }
            return false;
        }

        public Ambiente pesquisarAmbiente(Ambiente ambiente)
        {
            foreach (Ambiente amb in Ambientes)
            {
                if (amb.Id == ambiente.Id)
                {
                    return amb;
                }
            }
            return ambiente;
        }
        public void Upload() 
        {
            Conexao con = new Conexao();
            SqlCommand cmd = new SqlCommand();
            string retornoConexao = "";           
            //Enviar Comando SQL
            cmd.CommandText = "";
            try
            {
                //Conectar com o banco
                cmd.Connection = con.conectar();               
                //desconectando o banco
                //con.disconectar();
                retornoConexao = "Entrou no SQL!";
            

            foreach (Usuario user in this.usuarios)
            {
                cmd.CommandText = "insert into Usuario(id,nome) values(@id,@nome)";
                cmd.Parameters.AddWithValue("@id",user.Id);
                cmd.Parameters.AddWithValue("@nome", user.Nome);
                //executar comando
                cmd.ExecuteNonQuery();
                foreach (Ambiente am in user.Ambientes)
                    {
                        cmd.CommandText = "insert into Usuario_Ambiente(id_user,id_ambiente) values(@id_user,@id_ambiente)";
                        cmd.Parameters.AddWithValue("@id_user", user.Id);
                        cmd.Parameters.AddWithValue("@id_ambiente", am.Id);
                        //executar comando
                        cmd.ExecuteNonQuery();
                    }
            }
            foreach (Ambiente amb in this.ambientes)
            {
                    cmd.CommandText = "insert into Ambiente(id,nome) values(@id,@nome)";
                    cmd.Parameters.AddWithValue("@id", amb.Id);
                    cmd.Parameters.AddWithValue("@nome", amb.Nome);
                    //executar comando
                    cmd.ExecuteNonQuery();
                    foreach (Log lg in amb.logs) 
                    {
                        cmd.CommandText = "insert into Log(id_ambiente,dtAcesso,tipoAcesso,usuario) values(@id_ambiente,@dtAcesso,@tipoAcesso,@usuario)";
                        cmd.Parameters.AddWithValue("@id_ambiente", amb.Id);
                        cmd.Parameters.AddWithValue("@dtAcesso", lg.DtAcesso);
                        if (lg.TipoAcesso)
                        {
                            cmd.Parameters.AddWithValue("@tipoAcesso","TRUE");
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@@tipoAcesso", "FALSE");
                        }
                        cmd.Parameters.AddWithValue("@usuario", lg.Usuario);
                        //executar comando
                        cmd.ExecuteNonQuery();
                    }
            }            
                con.disconectar();
            }
            catch (SqlException ex)
            {
                retornoConexao = "Erro ao tentar conectar com o SQL Server";
            }
                
        {
        }
    
}

