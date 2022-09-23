FROM mysql:5.7.22
EXPOSE 3306
COPY ./RestWithASPNetUdemy/db/migrations/ /home/databse/
COPY ./RestWithASPNetUdemy/db/dataset/ /home/databse/
COPY ./RestWithASPNetUdemy/ci/init_database.sh/ /docker-entrypoint-initdb.d/init_database.sh