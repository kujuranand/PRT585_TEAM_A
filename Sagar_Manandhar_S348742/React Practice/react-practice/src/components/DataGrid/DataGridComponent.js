import { DataGrid } from '@mui/x-data-grid';

import * as React from 'react';
import { useEffect, useState } from 'react';
import Box from '@mui/material/Box';
import { Container } from '@mui/system';

const columns = [
  { field: 'id', headerName: 'ID', width: 90 },
  {
    field: 'name',
    headerName: 'Name',
    width: 150,
    editable: false,
  },
  {
    field: 'email',
    headerName: 'Email',
    width: 150,
    editable: false,
  },
];

export default function DataGridDemo() {

  const [rows, setRows] = useState([]); 

  // fetching data 
  const fetchData = async () => {
    const response = await fetch("https://localhost:7246/api/lecturer");
    const data = await response.json(); 
    setRows(data);
  }

  useEffect( () => {
    fetchData()
  }, [])


  return (
    <Container>
        <Box sx={{ height: 400, width: '100%' }}>
            <h1>Lecturer Table</h1>  
            <DataGrid
                rows={rows}
                columns={columns}
                pageSize={5}
                rowsPerPageOptions={[5]}
                checkboxSelection
                disableSelectionOnClick
                experimentalFeatures={{ newEditingApi: true }}
            />
        </Box>
    </Container>
    
  );
}
