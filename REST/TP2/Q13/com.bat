javac -d WEB-INF/classes mohammed/*.java

jar cvf R2Q13.war WEB-INF/

asadmin deploy --force R2Q13.war
