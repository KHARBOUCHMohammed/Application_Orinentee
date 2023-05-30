javac -d WEB-INF/classes mohammed/*.java

jar cvf Rest2Q3.war WEB-INF/

asadmin deploy --force Rest2Q3.war

