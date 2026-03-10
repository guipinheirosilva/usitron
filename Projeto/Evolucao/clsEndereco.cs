using System;
using System.Collections.Generic;
using System.Text;

namespace Evolucao
{
    class clsEndereco
    {
        #region Classe Endereço
        public class Endereco
        {
            private string _tipoLogradouro;
            public string TipoLogradouro
            {
                get { return _tipoLogradouro; }
                set { _tipoLogradouro = value; }
            }

            private string _logradouro;
            public string Logradouro
            {
                get { return _logradouro; }
                set { _logradouro = value; }
            }

            private string _bairro;
            public string Bairro
            {
                get { return _bairro; }
                set { _bairro = value; }
            }

            private string _uf;
            public string UF
            {
                get { return _uf; }
                set { _uf = value; }
            }

            private string _cidade;
            public string Cidade
            {
                get { return _cidade; }
                set { _cidade = value; }
            }
            private string _IBGE;
            public string IBGE
            {
                get { return _IBGE; }
                set { _IBGE = value; }
            }
            private int _Resul;
            public int Resul
            {
                get { return _Resul; }
                set { _Resul = value; }
            }
            public Endereco() { }
        }
        #endregion

    }
}
