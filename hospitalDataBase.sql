/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2012                    */
/* Created on:     5/5/2018 3:30:26 PM                          */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('APPOINTMENT') and o.name = 'FK_APPOINTM_HAS_DOCTOR')
alter table APPOINTMENT
   drop constraint FK_APPOINTM_HAS_DOCTOR
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('APPOINTMENT') and o.name = 'FK_APPOINTM_MAKE_PATIENT')
alter table APPOINTMENT
   drop constraint FK_APPOINTM_MAKE_PATIENT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BED') and o.name = 'FK_BED_BELONG_TO_DEPARTME')
alter table BED
   drop constraint FK_BED_BELONG_TO_DEPARTME
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BED') and o.name = 'FK_BED_SUPERVISE_NURSE')
alter table BED
   drop constraint FK_BED_SUPERVISE_NURSE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BILL') and o.name = 'FK_BILL_CHECK_PATIENT')
alter table BILL
   drop constraint FK_BILL_CHECK_PATIENT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BUY') and o.name = 'FK_BUY_BUY_BILL')
alter table BUY
   drop constraint FK_BUY_BUY_BILL
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BUY') and o.name = 'FK_BUY_BUY2_MEDICINE')
alter table BUY
   drop constraint FK_BUY_BUY2_MEDICINE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CARRY_OUT') and o.name = 'FK_CARRY_OU_CARRY_OUT_DOCTOR')
alter table CARRY_OUT
   drop constraint FK_CARRY_OU_CARRY_OUT_DOCTOR
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CARRY_OUT') and o.name = 'FK_CARRY_OU_CARRY_OUT_SURGERY')
alter table CARRY_OUT
   drop constraint FK_CARRY_OU_CARRY_OUT_SURGERY
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('DOCTOR') and o.name = 'FK_DOCTOR_F_EMPLOYEE')
alter table DOCTOR
   drop constraint FK_DOCTOR_F_EMPLOYEE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('EMPLOYEE') and o.name = 'FK_EMPLOYEE_WORKS_DEPARTME')
alter table EMPLOYEE
   drop constraint FK_EMPLOYEE_WORKS_DEPARTME
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('HELP_IN') and o.name = 'FK_HELP_IN_HELP_IN_NURSE')
alter table HELP_IN
   drop constraint FK_HELP_IN_HELP_IN_NURSE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('HELP_IN') and o.name = 'FK_HELP_IN_HELP_IN2_SURGERY')
alter table HELP_IN
   drop constraint FK_HELP_IN_HELP_IN2_SURGERY
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('NURSE') and o.name = 'FK_NURSE_D_EMPLOYEE')
alter table NURSE
   drop constraint FK_NURSE_D_EMPLOYEE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('SURGERY') and o.name = 'FK_SURGERY_UNDERGOES_PATIENT')
alter table SURGERY
   drop constraint FK_SURGERY_UNDERGOES_PATIENT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('VISITOR') and o.name = 'FK_VISITOR_VISITS_PATIENT')
alter table VISITOR
   drop constraint FK_VISITOR_VISITS_PATIENT
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('APPOINTMENT')
            and   name  = 'HAS_FK'
            and   indid > 0
            and   indid < 255)
   drop index APPOINTMENT.HAS_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('APPOINTMENT')
            and   name  = 'MAKE_FK'
            and   indid > 0
            and   indid < 255)
   drop index APPOINTMENT.MAKE_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('APPOINTMENT')
            and   type = 'U')
   drop table APPOINTMENT
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BED')
            and   name  = 'SUPERVISE_FK'
            and   indid > 0
            and   indid < 255)
   drop index BED.SUPERVISE_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BED')
            and   name  = 'BELONG_TO_FK'
            and   indid > 0
            and   indid < 255)
   drop index BED.BELONG_TO_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('BED')
            and   type = 'U')
   drop table BED
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BILL')
            and   name  = 'CHECK_FK'
            and   indid > 0
            and   indid < 255)
   drop index BILL.CHECK_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('BILL')
            and   type = 'U')
   drop table BILL
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BUY')
            and   name  = 'BUY2_FK'
            and   indid > 0
            and   indid < 255)
   drop index BUY.BUY2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BUY')
            and   name  = 'BUY_FK'
            and   indid > 0
            and   indid < 255)
   drop index BUY.BUY_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('BUY')
            and   type = 'U')
   drop table BUY
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CARRY_OUT')
            and   name  = 'CARRY_OUT2_FK'
            and   indid > 0
            and   indid < 255)
   drop index CARRY_OUT.CARRY_OUT2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CARRY_OUT')
            and   name  = 'CARRY_OUT_FK'
            and   indid > 0
            and   indid < 255)
   drop index CARRY_OUT.CARRY_OUT_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CARRY_OUT')
            and   type = 'U')
   drop table CARRY_OUT
go

if exists (select 1
            from  sysobjects
           where  id = object_id('DEPARTMENT')
            and   type = 'U')
   drop table DEPARTMENT
go

if exists (select 1
            from  sysobjects
           where  id = object_id('DOCTOR')
            and   type = 'U')
   drop table DOCTOR
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('EMPLOYEE')
            and   name  = 'WORKS_ON_FK'
            and   indid > 0
            and   indid < 255)
   drop index EMPLOYEE.WORKS_ON_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('EMPLOYEE')
            and   type = 'U')
   drop table EMPLOYEE
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('HELP_IN')
            and   name  = 'HELP_IN2_FK'
            and   indid > 0
            and   indid < 255)
   drop index HELP_IN.HELP_IN2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('HELP_IN')
            and   name  = 'HELP_IN_FK'
            and   indid > 0
            and   indid < 255)
   drop index HELP_IN.HELP_IN_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('HELP_IN')
            and   type = 'U')
   drop table HELP_IN
go

if exists (select 1
            from  sysobjects
           where  id = object_id('MEDICINE')
            and   type = 'U')
   drop table MEDICINE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('NURSE')
            and   type = 'U')
   drop table NURSE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PATIENT')
            and   type = 'U')
   drop table PATIENT
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('SURGERY')
            and   name  = 'UNDERGOES_FK'
            and   indid > 0
            and   indid < 255)
   drop index SURGERY.UNDERGOES_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('SURGERY')
            and   type = 'U')
   drop table SURGERY
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('VISITOR')
            and   name  = 'VISITS_FK'
            and   indid > 0
            and   indid < 255)
   drop index VISITOR.VISITS_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('VISITOR')
            and   type = 'U')
   drop table VISITOR
go

/*==============================================================*/
/* Table: APPOINTMENT                                           */
/*==============================================================*/
create table APPOINTMENT (
   APPOINTMENT_NO_      int                  not null,
   PATIENT_ID           int                  null,
   EMPLOYEE_ID          int                  null,
   APPOINTMENT_DATE     datetime             null,
   constraint PK_APPOINTMENT primary key (APPOINTMENT_NO_)
)
go

/*==============================================================*/
/* Index: MAKE_FK                                               */
/*==============================================================*/




create nonclustered index MAKE_FK on APPOINTMENT (PATIENT_ID ASC)
go

/*==============================================================*/
/* Index: HAS_FK                                                */
/*==============================================================*/




create nonclustered index HAS_FK on APPOINTMENT (EMPLOYEE_ID ASC)
go

/*==============================================================*/
/* Table: BED                                                   */
/*==============================================================*/
create table BED (
   ROOMNO_              int                  null,
   BED_ID               int                  not null,
   DEP_CODE             int                  not null,
   EMPLOYEE_ID          int                  not null,
   constraint PK_BED primary key (BED_ID)
)
go

/*==============================================================*/
/* Index: BELONG_TO_FK                                          */
/*==============================================================*/




create nonclustered index BELONG_TO_FK on BED (DEP_CODE ASC)
go

/*==============================================================*/
/* Index: SUPERVISE_FK                                          */
/*==============================================================*/




create nonclustered index SUPERVISE_FK on BED (EMPLOYEE_ID ASC)
go

/*==============================================================*/
/* Table: BILL                                                  */
/*==============================================================*/
create table BILL (
   BILL_CODE            int                  not null,
   PATIENT_ID           int                  null,
   BILL_PRICE           float                null,
   constraint PK_BILL primary key (BILL_CODE)
)
go

/*==============================================================*/
/* Index: CHECK_FK                                              */
/*==============================================================*/




create nonclustered index CHECK_FK on BILL (PATIENT_ID ASC)
go

/*==============================================================*/
/* Table: BUY                                                   */
/*==============================================================*/
create table BUY (
   BILL_CODE            int                  not null,
   MED_NAME             varchar(10)          not null,
   constraint PK_BUY primary key (BILL_CODE, MED_NAME)
)
go

/*==============================================================*/
/* Index: BUY_FK                                                */
/*==============================================================*/




create nonclustered index BUY_FK on BUY (BILL_CODE ASC)
go

/*==============================================================*/
/* Index: BUY2_FK                                               */
/*==============================================================*/




create nonclustered index BUY2_FK on BUY (MED_NAME ASC)
go

/*==============================================================*/
/* Table: CARRY_OUT                                             */
/*==============================================================*/
create table CARRY_OUT (
   EMPLOYEE_ID          int                  not null,
   SURGERY_NO_          int                  not null,
   constraint PK_CARRY_OUT primary key (EMPLOYEE_ID, SURGERY_NO_)
)
go

/*==============================================================*/
/* Index: CARRY_OUT_FK                                          */
/*==============================================================*/




create nonclustered index CARRY_OUT_FK on CARRY_OUT (EMPLOYEE_ID ASC)
go

/*==============================================================*/
/* Index: CARRY_OUT2_FK                                         */
/*==============================================================*/




create nonclustered index CARRY_OUT2_FK on CARRY_OUT (SURGERY_NO_ ASC)
go

/*==============================================================*/
/* Table: DEPARTMENT                                            */
/*==============================================================*/
create table DEPARTMENT (
   DEP_CODE             int                  not null,
   DEP_NAME             varchar(10)          null,
   constraint PK_DEPARTMENT primary key (DEP_CODE)
)
go

/*==============================================================*/
/* Table: DOCTOR                                                */
/*==============================================================*/
create table DOCTOR (
   EMPLOYEE_ID          int                  not null,
   DEP_CODE             int                  null,
   PHONE_NO_            numeric(10)          null,
   EMPLOYEE_NAME        varchar(10)          null,
   EMPLOYEE_DOB         datetime             null,
   EMPLOYEE_ADDRESS     varchar(10)          null,
   EMPLOYEE_GENDER      varchar(10)          null,
   RANK                 int                  null,
   constraint PK_DOCTOR primary key (EMPLOYEE_ID)
)
go

/*==============================================================*/
/* Table: EMPLOYEE                                              */
/*==============================================================*/
create table EMPLOYEE (
   EMPLOYEE_ID          int                  not null,
   DEP_CODE             int                  not null,
   PHONE_NO_            numeric(10)          null,
   EMPLOYEE_NAME        varchar(10)          null,
   EMPLOYEE_DOB         datetime             null,
   EMPLOYEE_ADDRESS     varchar(10)          null,
   EMPLOYEE_GENDER      varchar(10)          null,
   constraint PK_EMPLOYEE primary key (EMPLOYEE_ID)
)
go

/*==============================================================*/
/* Index: WORKS_ON_FK                                           */
/*==============================================================*/




create nonclustered index WORKS_ON_FK on EMPLOYEE (DEP_CODE ASC)
go

/*==============================================================*/
/* Table: HELP_IN                                               */
/*==============================================================*/
create table HELP_IN (
   EMPLOYEE_ID          int                  not null,
   SURGERY_NO_          int                  not null,
   constraint PK_HELP_IN primary key (EMPLOYEE_ID, SURGERY_NO_)
)
go

/*==============================================================*/
/* Index: HELP_IN_FK                                            */
/*==============================================================*/




create nonclustered index HELP_IN_FK on HELP_IN (EMPLOYEE_ID ASC)
go

/*==============================================================*/
/* Index: HELP_IN2_FK                                           */
/*==============================================================*/




create nonclustered index HELP_IN2_FK on HELP_IN (SURGERY_NO_ ASC)
go

/*==============================================================*/
/* Table: MEDICINE                                              */
/*==============================================================*/
create table MEDICINE (
   MED_NAME             varchar(10)          not null,
   QUANTITY             int                  null,
   constraint PK_MEDICINE primary key (MED_NAME)
)
go

/*==============================================================*/
/* Table: NURSE                                                 */
/*==============================================================*/
create table NURSE (
   EMPLOYEE_ID          int                  not null,
   DEP_CODE             int                  null,
   PHONE_NO_            numeric(10)          null,
   EMPLOYEE_NAME        varchar(10)          null,
   EMPLOYEE_DOB         datetime             null,
   EMPLOYEE_ADDRESS     varchar(10)          null,
   EMPLOYEE_GENDER      varchar(10)          null,
   constraint PK_NURSE primary key (EMPLOYEE_ID)
)
go

/*==============================================================*/
/* Table: PATIENT                                               */
/*==============================================================*/
create table PATIENT (
   PATIENT_ID           int                  not null,
   PATIENT_DOB          datetime             null,
   PATIENT_GENDER       varchar(6)           null,
   PATIENT_NAME         varchar(10)          null,
   PATIENT_ADDRESS      varchar(20)          null,
   PATIENT_CONTACT      numeric(10)          null,
   constraint PK_PATIENT primary key (PATIENT_ID)
)
go

/*==============================================================*/
/* Table: SURGERY                                               */
/*==============================================================*/
create table SURGERY (
   SURGERY_NO_          int                  not null,
   PATIENT_ID           int                  null,
   ROOM_NO_             int                  null,
   SURGERY_DATE         datetime             null,
   constraint PK_SURGERY primary key (SURGERY_NO_)
)
go

/*==============================================================*/
/* Index: UNDERGOES_FK                                          */
/*==============================================================*/




create nonclustered index UNDERGOES_FK on SURGERY (PATIENT_ID ASC)
go

/*==============================================================*/
/* Table: VISITOR                                               */
/*==============================================================*/
create table VISITOR (
   SSN                  int                  not null,
   PATIENT_ID           int                  null,
   VISITOR_NAME         varchar(10)          null,
   constraint PK_VISITOR primary key (SSN)
)
go

/*==============================================================*/
/* Index: VISITS_FK                                             */
/*==============================================================*/




create nonclustered index VISITS_FK on VISITOR (PATIENT_ID ASC)
go

alter table APPOINTMENT
   add constraint FK_APPOINTM_HAS_DOCTOR foreign key (EMPLOYEE_ID)
      references DOCTOR (EMPLOYEE_ID)
go

alter table APPOINTMENT
   add constraint FK_APPOINTM_MAKE_PATIENT foreign key (PATIENT_ID)
      references PATIENT (PATIENT_ID)
go

alter table BED
   add constraint FK_BED_BELONG_TO_DEPARTME foreign key (DEP_CODE)
      references DEPARTMENT (DEP_CODE)
go

alter table BED
   add constraint FK_BED_SUPERVISE_NURSE foreign key (EMPLOYEE_ID)
      references NURSE (EMPLOYEE_ID)
go

alter table BILL
   add constraint FK_BILL_CHECK_PATIENT foreign key (PATIENT_ID)
      references PATIENT (PATIENT_ID)
go

alter table BUY
   add constraint FK_BUY_BUY_BILL foreign key (BILL_CODE)
      references BILL (BILL_CODE)
go

alter table BUY
   add constraint FK_BUY_BUY2_MEDICINE foreign key (MED_NAME)
      references MEDICINE (MED_NAME)
go

alter table CARRY_OUT
   add constraint FK_CARRY_OU_CARRY_OUT_DOCTOR foreign key (EMPLOYEE_ID)
      references DOCTOR (EMPLOYEE_ID)
go

alter table CARRY_OUT
   add constraint FK_CARRY_OU_CARRY_OUT_SURGERY foreign key (SURGERY_NO_)
      references SURGERY (SURGERY_NO_)
go

alter table DOCTOR
   add constraint FK_DOCTOR_F_EMPLOYEE foreign key (EMPLOYEE_ID)
      references EMPLOYEE (EMPLOYEE_ID)
go

alter table EMPLOYEE
   add constraint FK_EMPLOYEE_WORKS_DEPARTME foreign key (DEP_CODE)
      references DEPARTMENT (DEP_CODE)
go

alter table HELP_IN
   add constraint FK_HELP_IN_HELP_IN_NURSE foreign key (EMPLOYEE_ID)
      references NURSE (EMPLOYEE_ID)
go

alter table HELP_IN
   add constraint FK_HELP_IN_HELP_IN2_SURGERY foreign key (SURGERY_NO_)
      references SURGERY (SURGERY_NO_)
go

alter table NURSE
   add constraint FK_NURSE_D_EMPLOYEE foreign key (EMPLOYEE_ID)
      references EMPLOYEE (EMPLOYEE_ID)
go

alter table SURGERY
   add constraint FK_SURGERY_UNDERGOES_PATIENT foreign key (PATIENT_ID)
      references PATIENT (PATIENT_ID)
go

alter table VISITOR
   add constraint FK_VISITOR_VISITS_PATIENT foreign key (PATIENT_ID)
      references PATIENT (PATIENT_ID)
go

