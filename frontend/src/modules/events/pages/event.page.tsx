import { Outlet } from 'react-router-dom';

const EventPage = () => {
  return (
    <div style={{ height: 'calc(100vh - 130px)' }}>
      <Outlet />
    </div>
  );
};

export default EventPage;
