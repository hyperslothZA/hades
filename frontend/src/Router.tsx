import { createBrowserRouter, RouterProvider } from 'react-router-dom';
import { HomePage } from './pages/Home.page';
import MainLayout from './layouts/MainLayout';
import AddEvent from './modules/events/event/addEvent';
import EventList from './modules/events/eventList/eventList';
import EventPage from './modules/events/pages/event.page';

const router = createBrowserRouter([
  {
    path: '/',
    element: <MainLayout />,
    children: [
      {
        path: '/',
        element: <EventPage />,
        children: [
          {
            index: true,
            element: <EventList />,
          },
          {
            path: '/new',
            element: <AddEvent />,
          },
        ],
      },
    ],
  },
]);

export function Router() {
  return <RouterProvider router={router} />;
}
