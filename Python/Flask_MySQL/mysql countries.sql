--1.
select countries.name as name, languages.language as language, languages.percentage as percentage
from countries
join languages
on countries.id = languages.country_id
where languages.language = 'Slovene'

--2.
