# universityP


Oracle database query
데이터베이스 접속 아이디 : jin
데이터베이스 접속 비밀번호 : 0317


---프로그램--
관리자 아이디 : 9999
관리자 비밀번호 : 0317




-------------------------------------------------------------------------------------------------------
CREATE TABLE 학과 (
	학과이름 	VARCHAR(20) 	NOT NULL ,
   	단과대학 	VARCHAR(20) 	NOT NULL,
	과사무실 VARCHAR(10) 	NOT NULL,
       	CONSTRAINT 학과_PK PRIMARY KEY (학과이름)
	);





-------------------------------------------------------------------------------------------------------

CREATE TABLE 교수 (
	교수번호 	VARCHAR(20) 	NOT NULL,
	이름 VARCHAR(20) 	NOT NULL,   	
	비밀번호 	VARCHAR(64) 	NOT NULL,
   	학과이름 	VARCHAR(20) 	NOT NULL,
   	CONSTRAINT 교수_PK PRIMARY KEY (교수번호),
       	CONSTRAINT 교수_학과이름_FK FOREIGN KEY(학과이름) REFERENCES  학과(학과이름) 
	);




--------------------------------------------------------------------------------------------------------
	
create table 학생 (
	학번 VARCHAR(20) not null,
	이름 VARCHAR(20) not null,
	학년 VARCHAR(1) not null,
	비밀번호 VARCHAR(64) not null,
	지도교수 VARCHAR(20) not null,
	학과이름 VARCHAR(20) not null,
	constraint 학생_PK primary key (학번),
	CONSTRAINT 학생_지도교수_FK FOREIGN KEY(지도교수) REFERENCES  교수(교수번호),
	CONSTRAINT 학생_학과이름_FK FOREIGN KEY(학과이름) REFERENCES  학과(학과이름) 
	);




-------------------------------------------------------------------------------------------------------



create table 과목 ( 
	과목번호 VARCHAR(20) not null,
	과목이름 VARCHAR(20) not null,
	대상학년 VARCHAR(1) not null,
	개설학기 VARCHAR(1) not null,
	전공구분 VARCHAR(5) not null,
	이수학점 VARCHAR(10) not null,
	학과이름 VARCHAR(20) not null,
	CONSTRAINT 과목_PK PRIMARY KEY (과목번호),
	constraint 과목_학과이름_FK FOREIGN KEY(학과이름) references 학과(학과이름)
	);



------------------------------------------------------------------------------------------

create table 개설과목(
	과목번호 VARCHAR(20) not null,
	연도 VARCHAR(4) not null,
	학기 VARCHAR(1) not null,
	담당교수번호 VARCHAR(20) not null,
	교재 BLOB,
	CONSTRAINT 개설과목_PK PRIMARY KEY (과목번호, 연도, 학기),
	constraint 개설과목_과목번호_FK FOREIGN KEY(과목번호) references 과목(과목번호),
	constraint 개설과목_담당교수번호_FK FOREIGN KEY(담당교수번호) references 교수(교수번호)
);



------------------------------------------------------------------------------------------

create table 수강(
	학번 VARCHAR(20) not null,
	과목번호 VARCHAR(20) not null,
	연도 VARCHAR(4) not null,
	학기 VARCHAR(1) not null,
	성적 VARCHAR(1) check(성적 in('A', 'B', 'C', 'F')),
	승인 VARCHAR(4) NULL;                                                       --승인여부
	CONSTRAINT 수강_PK PRIMARY KEY (학번, 과목번호, 연도, 학기),
	constraint 수강_학번_FK FOREIGN KEY(학번) references 학생(학번),
	constraint 수강_과목번호_FK FOREIGN KEY(과목번호) references 개설과목(과목번호)
);

------------------------------------------------------------------------------------------

create table 상담(
	학번 VARCHAR(10) not null,
	상담일자 DATE not null,                               --YY-MM-DD
	상담내용 LONG not null,
	constraint 상담_PK PRIMARY KEY (학번, 상담일자),
	constraint 상담_학번_FK FOREIGN KEY(학번) references 학생(학번)
);




