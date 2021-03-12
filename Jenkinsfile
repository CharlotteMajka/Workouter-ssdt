pipeline {
    agent any
    stages {
        stage("Build application") {
            steps {
                sh "dotnet build src/Workouter.sln"
                sh "docker build . -t lechampdk/workouter"
               withCredentials([[$class: 'UsernamePasswordMultiBinding', credentialsId: '69e5c2f8-8f3b-4461-b829-e3532bc4b156', usernameVariable: 'USERNAME', passwordVariable: 'PASSWORD']])
				{
					sh 'docker login -u ${USERNAME} -p ${PASSWORD}'
				}
                sh "docker push lechampdk/workouter"
            }
        }
	stage("Build DB") {
	    steps{
		 sh  "dotnet build db/Workouter-SSDT/Workouter-SSDT.sqlproj /p:NetCoreBuild=true /p:NETCoreTargetsPath=/opt/ssdt/.azuredatastudio/extensions/microsoft.sql-database-projects-0.6.1/BuildDirectory"
	         }
	    	 } 
        stage("Release to staging") {
            steps {
                sh "docker-compose pull"
                sh "docker-compose up -d application mssql-db"
            }
        }
    }
}
