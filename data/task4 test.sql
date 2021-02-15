SELECT date AS DATE, sum(negative)+sum(positive) AS TOT, DescriptionOfMeasure AS DESCR
FROM us_states_covid19_daily join covid_mitigation_usa on us_states_covid19_daily.date = DATE_FORMAT(STR_TO_DATE(StartDate, "%M %d, %Y"),"%Y%m%d")
WHERE state LIKE 'IL'
GROUP BY date
ORDER BY date;