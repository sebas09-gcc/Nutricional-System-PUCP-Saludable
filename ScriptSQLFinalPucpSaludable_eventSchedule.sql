CREATE EVENT event1
  ON SCHEDULE EVERY '1' DAY
  STARTS '2020-01-01 20:05:00'    
DO 
	update cita
    set estado = 3
    where estado = 0
    and CURDATE() = DATE(fechahoraatencion);