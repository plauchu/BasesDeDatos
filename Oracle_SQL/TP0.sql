-- 1: diferencia en SQL standar.
SELECT nomprof,
  categoría
FROM prof
WHERE idprof NOT IN
  (SELECT idprof FROM grupo
  )
-- En Oracle
SELECT nomprof, categoría FROM prof
MINUS
SELECT nomprof, categoría FROM prof p, grupo g WHERE p.idprof = g.idprof 

-- 2
select nommat, avg(calif) "Promedio"
from mater m, historial h
where calif >=6 and extract(year from fecha)= extract(year from sysdate)-1 and 
  m.clavem = h.clavem
group by nommat

-- 3
select nommat, count(distinct calif) 
from mater m, historial h
where m.clavem = h.clavem
group by nommat 
having count(distinct calif)>2

-- 4
select nomal
from alum a, historial h, mater m
where nommat like 'Algo%' and 
  a.cu = h.cu and h.clavem = m.clavem
  intersect 
select nomal
from alum a, historial h, mater m
where nommat = 'Economía I' and 
  a.cu = h.cu and h.clavem = m.clavem
  
-- 5
select carr, nommat, count(*)
from alum a, mater m, historial h
where extract (year from fecha) = 2019 
  and a.cu = h.cu and h.clavem=m.clavem
group by carr, nommat
order by carr

-- 8) 
select nommat, nomal 
from mater m, inscrito i, grupo g, alum a
where m.clavem =g.clavem and i.claveg=g.claveg and a.cu = i.cu 
  and nommat in 
        (select nommat 
        from mater m, inscrito i, grupo g
        where m.clavem =g.clavem and i.claveg=g.claveg 
        group by nommat
        having count(*)<=3)
-- 9)
select NomAl, Prom, Carr
from Alum
where Prom <= all (select Prom from Alum)
or Prom >= all (select Prom from Alum)

-- 10)
select NomAl, Prom
from Alum
where Prom >  (select AVG(Prom) from Alum)




