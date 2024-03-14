import { Box, Grid, Select, TextInput } from '@mantine/core';
import { useForm } from '@mantine/form';

const AddEvent = () => {
  const form = useForm({
    initialValues: {
      name: '',
      venue: '',
      school: '',
    },
  });

  return (
    <>
      <Grid>
        <Grid.Col span={12}>
          <h1>Add Event</h1>
        </Grid.Col>
        <Grid.Col span={12}>
          <Box>
            <Grid>
              <Grid.Col span={6}>
                <TextInput label="Name" placeholder="Name" {...form.getInputProps('name')} />
              </Grid.Col>
              <Grid.Col span={6}>
                <TextInput label="Venue" placeholder="Venue" {...form.getInputProps('venue')} />
              </Grid.Col>
              <Grid.Col span={6}>
                <Select
                  label="School"
                  placeholder="School"
                  data={['React', 'Angular', 'Vue', 'Svelte']}
                  searchable
                  {...form.getInputProps('school')}
                />
              </Grid.Col>
            </Grid>
          </Box>
        </Grid.Col>
      </Grid>
    </>
  );
};

export default AddEvent;
