namespace refatoracao.R12.ExtractClass.antes
{
    class Empresa
    {   

        public Empresa(RazaoSocial razaoSocial, CNPJ cnpj, Endereco endereco)
        {
            RazaoSocial = razaoSocial;
            CNPJ = cnpj;
            Endereco = endereco;
        }

        public RazaoSocial RazaoSocial { get; private set; }

        public CNPJ CNPJ { get; private set; }
        public Endereco Endereco { get; private set;}
    }
    class CNPJ
    {
        public string Codigo { get; private set; }

        public CNPJ(string codigo)
        {
            this.Codigo = codigo;
        }
    }

    class RazaoSocial
    {
        public string Nome { get; private set; }

        public RazaoSocial(string nome)
        {
            Nome = nome;
        }
    }

     class Endereco
    {
        public int TipoEnd { get; private set; }  
        //0 Entrega
        //1 Comercial  
        public string EndLogradouro { get; private set; }
        public string EndNumero { get; private set; }
        public string EndComplemento { get; private set; }
        public string EndBairro { get; private set; }
        public string EndCEP { get; private set; }
        public string EndMunicipio { get; private set; }
        public string EndUF { get; private set; }


        public Endereco(int tipoEnd, string endLogradouro, string endNumero, string endComplemento, string endBairro, string endCEP, string endMunicipio, string endUF)
        {
            TipoEnd        = tipoEnd;
            EndLogradouro  = endLogradouro;
            EndNumero      = endNumero;
            EndComplemento = endComplemento;
            EndBairro      = endBairro;
            EndCEP         = endCEP;
            EndMunicipio   = endMunicipio;
            EndUF          = endUF;
        }

        public string GetTextoEndereco(int TipoEnd)
        {
            return $"Endereço:  {EndLogradouro} {EndNumero} {EndComplemento} - {EndBairro} - CEP {EndCEP} - {EndMunicipio} - {EndUF}";
        }

        public void UpdateEndereco(int tipoEnd ,string endLogradouro, string endNumero, string endComplemento, string endBairro, string endCEP, string endMunicipio, string endUF)
        {
            TipoEnd = tipoEnd;
            EndLogradouro = endLogradouro;
            EndNumero = endNumero;
            EndComplemento = endComplemento;
            EndBairro = endBairro;
            EndCEP = endCEP;
            EndMunicipio = endMunicipio;
            EndUF = endUF;
        }
    }
}
