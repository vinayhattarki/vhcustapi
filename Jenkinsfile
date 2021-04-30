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
		println("Step: Checkout Code Repo")
		checkout scm  
	  }
	  
	  stage('Build Code Repository')
	  {
		println("Step: Build Code Repository")
	  }
	  
	  stage('Run Unit Tests')
	  {
		println("Step: Run Unit Tests")
	  }
	  
	  stage('Publish Code to Stage Location')
	  {
		println("Step: Publish Code to Stage Location")
	  }
	  
	  stage('Notify-Email')
	  {
		println("Step: Notify-Email")
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
