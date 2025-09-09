public class Televisao 
class Televisao:
    def __init__(self, total_canais=520, volume_maximo=100):
        self.total_canais = total_canais
        self.volume_maximo = volume_maximo
        self.canal_atual = 1
        self.ultimo_canal = 1
        self.volume_atual = 50
        self.mudo_ativado = False

    # ---------------------------
    # GERENCIAMENTO DE CANAIS
    # ---------------------------
    def ligar_tv(self):
        """Ao ligar a TV, retorna o último canal assistido"""
        self.canal_atual = self.ultimo_canal
        return self.canal_atual

    def ir_para_canal(self, numero_canal):
        """Vai direto para o canal informado"""
        if 1 <= numero_canal <= self.total_canais:
            self.ultimo_canal = numero_canal
            self.canal_atual = numero_canal
        else:
            raise ValueError(f"Canal inválido! A TV suporta de 1 até {self.total_canais}.")

    def canal_acima(self):
        """Passa para o próximo canal"""
        if self.canal_atual < self.total_canais:
            self.canal_atual += 1
        else:
            self.canal_atual = 1  # Volta para o início
        self.ultimo_canal = self.canal_atual

    def canal_abaixo(self):
        """Volta para o canal anterior"""
        if self.canal_atual > 1:
            self.canal_atual -= 1
        else:
            self.canal_atual = self.total_canais  # Vai para o último canal
        self.ultimo_canal = self.canal_atual

    # ---------------------------
    # GERENCIAMENTO DE VOLUME
    # ---------------------------
    def aumentar_volume(self):
        """Aumenta o volume em 1"""
        if not self.mudo_ativado and self.volume_atual < self.volume_maximo:
            self.volume_atual += 1

    def reduzir_volume(self):
        """Reduz o volume em 1"""
        if not self.mudo_ativado and self.volume_atual > 0:
            self.volume_atual -= 1

    def ativar_mudo(self):
        """Ativa o mudo"""
        self.mudo_ativado = True

    def desativar_mudo(self):
        """Desativa o mudo"""
        self.mudo_ativado = False

    def obter_volume(self):
        """Retorna o volume atual considerando o mudo"""
        return 0 if self.mudo_ativado else self.volume_atual

    def obter_canal(self):
        """Retorna o canal atual"""
        return self.canal_atual
    private const int VOL_MAX = 100;
    public Televisao(float tamanho)
    {
        Tamanho = tamanho;
    } 
    
    public float Tamanho {get;set;}
    public int Resolucao {get; set;}
    public int Volume {get; private set;} 
    public int Canal {get; set;}
    public bool Estado {get; set;}  

    public void Aumentarvolume() 
    {
       if (volume < 100))
          Volume ++1;
       else 
        Console.WriteLine("Tv ja esta no max.");
    }    

}
