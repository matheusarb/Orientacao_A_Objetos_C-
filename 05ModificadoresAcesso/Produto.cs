class Produto
{
    /*
         * public    -> Atibutos e Métodos visíveis em quaisquer classes 
         * private   -> '' e '' visíveis apenas na classe onde são criados
         * protected -> '' e ''    '' em classes onde são criados ou herdados
     */

    public string? Nome { get; set; }
    private double Valor { get; set; }
}