//1
SELECT flex_employee.name, flex_employee.email , flex_orgnization 
FROM flex_employee 
JOIN flex_orgnization 
ON flex_employee.orgnization_id = flex_orgnization.parent_id 
JOIN flex_orgnization_employee 
ON flex_employee.employee_id = flex_orgnization_employee.employee_id;
//2
SELECT flex_employee.name, flex_employee.email 
FROM flex_employee
WHERE flex_employee.employee_id IN (
    SELECT flex_orgnization_employee.employee_id 
    FROM flex_orgnization_employee 
    JOIN flex_orgnization 
    ON flex_orgnization_employee.orgnization_id = flex_orgnization.parent_id;
); 
//3 
SELECT flex_employee.name, flex_employee.email 
FROM flex_employee
WHERE flex_employee.employee_id NOT IN (
    SELECT flex_orgnization_employee.employee_id 
    FROM flex_orgnization_employee 
    JOIN flex_orgnization 
    ON flex_orgnization_employee.orgnization_id = flex_orgnization.parent_id;
); 
//4 
SELECT flex_employee.name, flex_employee.email 
FROM flex_employee
WHERE flex_employee.employee_id IN (
    SELECT flex_orgnization_employee.employee_id 
    FROM flex_orgnization_employee 
    JOIN flex_orgnization 
    ON flex_orgnization_employee.orgnization_id = flex_orgnization.parent_id
    WHERE flex_orgnization.code = 'PB_001';
);
//5
check xem oke chua

