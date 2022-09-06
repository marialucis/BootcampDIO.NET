programa
{
	
	/*
	 * Programador(a): Luci Sousa
	 * Data:05/09/2022
	 * 
	 * Objetivo: Algoritmo desenvolvido para o calculo de média de 4 bimestres de uma escola
	 * 		   para praticar a lógica do pseudocodigo		
	 */
	
	funcao inicio()
	{
		real nota1, nota2, nota3, nota4, media		
		caracter nome

		escreva("Digite seu nome, Aluno: ")
		leia(nome)
		
		escreva("Digite a sua nota do Primeiro Bimestre: ")
		leia(nota1)
		escreva("Digite a sua nota do Segundo Bimestre: ")
		leia(nota2)
		escreva("Digite a sua nota do Terceiro Bimestre: ")
		leia(nota3)
		escreva("Digite a sua nota do Quarto Bimestre: ")
		leia(nota4)


		media = (nota1 + nota2 + nota3 + nota4)	/4 
				
		se (media >= 7){
			escreva(nome + ",Aprovado!")
		}
		senao 
		se(media == 6 ){
			escreva(nome+ ",Recuperação Final")		
		}
		senao
			escreva("Reprovado! Favor, dirija-se até a secretaria")
	}


	
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 559; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = {nota1, 14, 7, 5}-{nota2, 14, 14, 5}-{nota3, 14, 21, 5}-{nota4, 14, 28, 5}-{media, 14, 35, 5};
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */