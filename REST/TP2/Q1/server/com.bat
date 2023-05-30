javac -d WEB-INF/classes mohammed/*.java

jar cvf Rest2Q1.war WEB-INF/

asadmin deploy --force Rest2Q1.war

javac client/*.java




