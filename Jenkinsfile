#!groovy
import groovy.json.JsonOutput

String APP_Name     ='Cust_API'
String ENV          ='DEV'


println("THIS is DEV BRANCH")

//switch (BRANCH)
//{
//  case 'DEV'
//      ENV = 'DEV'
//	  println("THIS is DEV BRANCH")
//	  break
//  case 'TEST'
//      ENV = 'TEST'
//	  println("THIS is TEST BRANCH")
//	  break
//}


node () {
  try {
  	stage('Checkout Code Repo')
	  {
		println("You are inside node-Stage-Checkout Code Repo")
	  }
      }
	  
   catch (err)
   {
       
	   println("You are inside catch error")
   }
   
   finally 
   {
   
	   println("You are inside Finally block")
   }
}
