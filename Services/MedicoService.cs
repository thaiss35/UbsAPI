using System.Net.NetworkInformation;
using UbcApi.Models;

namespace UbcApi.Services
{
    public class MedicoService
    {
        MedicoModel medico1 = new()
        {
            Crm = "1",
            Nome = "Dra.Ana",
            Especialidade ="Clinica geral"
        };

        MedicoModel medico2 = new()
        {
            Crm = "2",
            Nome = "Dr.Jõao",
            Especialidade = "Cardiologista"
        };

        private static List<MedicoModel> _ListaModicos = new List<MedicoModel>
        {
            new MedicoModel {Crm = "2101PE",
            Nome = "Dra.Ana",
            Telefone = "81977742345",
            Especialidade ="Clinica geral",},
            
            new MedicoModel {Crm = "2304PE",
            Nome = "Dr.Jõao",
            Especialidade = "Cardiologista"}
        };
        
        public bool ValidarMedico (string crm)
        {
            foreach (MedicoModel medico in _ListaModicos)
            {
                if (medico.Crm == crm)
                {
                    return true;
                }
            }
            return false;
        }
        public bool CadastrarMedico (MedicoModel novoMedico)
        {
            if (ValidarMedico (novoMedico.Crm))
            {
                return false;
            }
            
            _ListaModicos.Add(novoMedico);
            return true;
        }
        public List<MedicoModel> ListarMedicos()
        {
            return _ListaModicos;
        }
        public MedicoModel BuscarMedico(string crmBuscar)
        {
            foreach (MedicoModel medico in _ListaModicos)
            {
                if (medico.Crm == crmBuscar)
                {
                    return medico;
                }               
            }
            return null;
        }
    }
}

