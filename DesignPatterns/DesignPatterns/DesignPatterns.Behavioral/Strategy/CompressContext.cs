namespace DesignPatterns.Behavioral.Strategy
{
    public class CompressContext
    {
        private ICompressao iCompressao;

        public CompressContext(ICompressao _iCompressao)
        {
            iCompressao = _iCompressao;
        }

        public void DefineStrategy(ICompressao compressao)
        {
            iCompressao = compressao;
        }

        public void CriarArquivoCompactado(string nomeArquivo)
        {
            iCompressao.ComprimirArquivo(nomeArquivo);
        }
    }
}