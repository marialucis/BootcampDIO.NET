programa
{
	
	funcao inicio()
	{
		inteiro nota1, nota2, media
		
		escreva("Digite as notas do bimestre: ")
		leia(nota1)
		leia(nota2)

		media = (nota1 + nota2) /2

		se (media >= 6) 
		{
			escreva("Aprovado: " +media) 
		}
		senao 
			escreva("Recuperação da nota bimestral") 
		
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 297; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */