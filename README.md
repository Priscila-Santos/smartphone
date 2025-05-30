# Sistema para Smartphone com .NET C#

Este é um projeto de aplicativo de console em C# que modela um sistema de celulares utilizando o conceito de orientação a objetos. O projeto inclui uma classe abstrata `Smartphone` e duas classes derivadas `Android` e `Ios`, cada uma com seu próprio comportamento para instalar aplicativos.

## 📁 Estrutura do Projeto

### Models/
- **Smartphone.cs**: Classe abstrata com os métodos e atributos comuns.
- **Android.cs**: Classe derivada que implementa `InstalarAplicativo` para Android.
- **Ios.cs**: Classe derivada que implementa `InstalarAplicativo` para iOS.

### Program.cs
- Classe principal que instancia e testa os objetos `Android` e `Ios`.

## ▶️ Como Executar

1. Realize um `fork` para o seu **GitHub**
2. Faça um clone para sua máquina:
```bash
git clone (link do repositório)
```
3. Execute o programa para ver a simulação de chamadas e instalação de aplicativos.
```bash
dotnet build
```
```bash
dotnet run
```

## 📌 Diagrama de Classes (Mermaid)

```mermaid
classDiagram
    class Smartphone {
        string Numero
        string Modelo
        string IMEI
        int Memoria
        +void Ligar()
        +void ReceberLigacao()
        +abstract void InstalarAplicativo(string nome)
    }

    class Android {
        +void InstalarAplicativo(string nome)
    }

    class Ios {
        +void InstalarAplicativo(string nome)
    }

    Smartphone <|-- Android
    Smartphone <|-- Ios
