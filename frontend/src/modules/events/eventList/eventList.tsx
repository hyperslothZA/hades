import { AgGridReact } from 'ag-grid-react';
import { useState } from 'react';

import { ColDef, ColGroupDef, ModuleRegistry } from '@ag-grid-community/core';
import { ActionIcon } from '@mantine/core';
import { IconPlus } from '@tabler/icons-react';
import { useNavigate } from 'react-router-dom';

interface IRow {
  name: string;
  venue: string;
  school: string;
}

const EventList = () => {
  const navigate = useNavigate();

  const [rowData, setRowData] = useState<IRow[]>([
    { name: 'Tesla', venue: 'Model Y', school: '64950' },
    { name: 'Ford', venue: 'F-Series', school: '33850' },
    { name: 'Toyota', venue: 'Corolla', school: '29600' },
  ]);

  const [colDefs, setColDefs] = useState<ColDef[]>([
    { field: 'name', flex: 1 },
    { field: 'venue' },
    { field: 'school' },
  ]);

  const addEvent = () => {
    navigate('/new');
  };

  return (
    // wrapping container with theme & size
    <div
      className="ag-theme-quartz" // applying the grid theme
      style={{ height: 'calc(100vh - 135px)' }}
    >
      <AgGridReact rowData={rowData} columnDefs={colDefs} />
      <div style={{ position: 'absolute', bottom: '20px', right: '30px' }}>
        <ActionIcon onClick={addEvent} variant="filled" size="lg" radius="xl" aria-label="Settings">
          <IconPlus style={{ width: '70%', height: '70%' }} stroke={1.5} />
        </ActionIcon>
      </div>
    </div>
  );
};

export default EventList;
