package br.com.caelum.financas.util

import javax.persistence.EntityManagerFactory;
import javax.persistence.Persistence;

public class JPAUtil{

    private static EntityManagerFactory emf = Persistence.createEntityManagerFactory("financas");

}