import Filter from "./Components/Search and filter features/filter";
import Query from "./Components/Search and filter features/query";
import Search from "./Components/Search and filter features/search";
import styles from "./page.module.css";

// Call fetch function to get all Animal Data, Uses searchParams and slicing data array to create pagination functionality. Sets conditions for buttons to become disabled for Pagination Component.
export default async function Home({ searchParams }: { searchParams: Promise<{query: string | undefined; filter: string | undefined }>}) {
  
  // Renders feature components to main section.
  return (
    <main className={styles.main}>
      <form className={styles.mainForm}>
        <h2 className={styles.formHeading}>Search for an Animal!</h2>
        <Search/>
        <Filter/>
      </form>
      <Query searchParams={searchParams}/>
    </main>
  );
}