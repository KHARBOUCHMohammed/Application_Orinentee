javac -d WEB-INF/classes mohammed/*.java

jar cvf Rest2Q2.war WEB-INF/

asadmin deploy --force Rest2Q2.war

